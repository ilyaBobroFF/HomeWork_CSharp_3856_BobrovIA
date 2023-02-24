#nullable disable
Console.Clear();
while(true)
{
    System.Console.WriteLine("Введите (54) или (56), или (58), или (60) для запуска решения задачи. (00) - для выхода");
    System.Console.Write("Ваш ввод: ");
    string task = Console.ReadLine();
    switch (task)
    {
        case "54": RunTask1(); break;
        case "56": RunTask2(); break;
        case "58": RunTask3(); break;
        case "60": RunTask4(); break;
        
    }
    if(task == "00") break;
}
//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void RunTask1()
{
    int row = new Random().Next(5, 10);
    int column = new Random().Next(5, 10);
    int minValue = new Random().Next(10, 50);
    int maxValue = new Random().Next(51, 99);
    int[,]ArrayMatrix = MakeMatrixInt(row, column, minValue, maxValue);
    PrintMatrix(ArrayMatrix, "No sort matrix Task_1");
    SortMinArrayString(ArrayMatrix);
    System.Console.WriteLine();
    PrintMatrix(ArrayMatrix, "Sorted matrix Task_1");
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void RunTask2()
{
    Console.Clear();
    System.Console.WriteLine();
    int[,] ArrayMatrix = MakeMatrixInt(3, 3, 1, 5);
    PrintMatrix(ArrayMatrix, "Input matrix Task_56");
    System.Console.WriteLine();
    FindMinSumRow(ArrayMatrix);
}

// Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void RunTask3()
{
    Console.Clear();
    int minValue = GetNumber("minValve", "Task_58");
    int maxValue = GetNumber("maxValve", "Task_58");
    int[,] matrixA = MakeMatrixInt(2, 2, minValue, maxValue);
    int[,] matrixB = MakeMatrixInt(2, 2, minValue, maxValue);
    PrintMatrix(matrixA, "Matrix A");
    PrintMatrix(matrixB, "Matrix B");
    PrintMatrix(MultyPlayMatrix(matrixA, matrixB), "MultyPlay Matrix C");
}

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void RunTask4()
{
    Console.Clear();
    int row = 2;
    int minValue = 10;
    int maxValue = 99;
    int[,,] matrix3D = Make3Dmatrix(row, minValue, maxValue);
    Print3DMatrix(matrix3D, "Task_60");
}    

///////////////////////////////////////////////:МЕТОДЫ:///////////////////////////////////////////////////////////////////
int[,] MakeMatrixInt(int row, int column, int minValue, int maxValue) // Метод создающий двухмерный массив целых чисел
{
    int[,] matrix = new int [row, column];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue+1);
            
        } 
        
    }
    return matrix;
}

void SortMinArrayString(int[,] matrix) // Сортирует методом пузырька по убыванию каждую строку матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > matrix[i, j-1])
            {
                int temp = matrix[i, j-1];
                matrix[i, j-1] = matrix[i, j];
                matrix[i, j] = temp;
                j = 0;
            }
        }
    }
}

void PrintMatrix(int[,] matrix, string name) // Метод отображающий массив в консоли
{
    System.Console.WriteLine($"{name} matrix({matrix.GetLength(0)}x{matrix.GetLength(1)}) = ");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        } 
        System.Console.WriteLine();
    }
    
}

void FindMinSumRow(int[,] matrix) // Находит строку с наименьшей суммой элементов (Первую по порядку, если их несколько)
{
    int[] sum = new int[matrix.GetLength(0)]; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            sum[i] += matrix [i,j];            
        }
    }
    
    int indexMin = 0;
    for(int i= 1; i < sum.Length; i++)
    {
        int minSumRow = sum[0];
        if (sum[i] < minSumRow) 
        {
            minSumRow = sum[i];
            indexMin = i;   
        }
    }
    System.Console.WriteLine("Number row have min sum elements = " + ++indexMin);
}

int [,] MultyPlayMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) == matrixB.GetLength(0))
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
    }
    else 
    {
        System.Console.WriteLine($"Multyplay matrixs imposible");
    }
    return matrixC;
}

int GetNumber (string nameNum, string task) // Метод передает переменной значение с консоли
{
    System.Console.Write($"Enter {nameNum} for {task}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,,] Make3Dmatrix(int row, int minValue, int maxValue)  // метод для создания  равносторонней трехмерной матрицы
{
    int[,,] matrix = new int [row, row, row];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int k = 0;
            while (k < matrix.GetLength(2))
            {
                bool next = false;
                int temp = new Random().Next(minValue, maxValue);               
                foreach (var el in matrix)
                {
                    if(el == temp) {next = true; break;}
                }
                if (next) {continue;}
                matrix[i, j, k++] = temp;                
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix, string name) // Метод отображающий только равностороную матрицу
{
    System.Console.WriteLine($"{name} matrix({matrix.GetLength(0)}x{matrix.GetLength(1)}x{matrix.GetLength(2)}) = ");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"({j}, {k}, {i}) = {matrix[j, k, i]} ");
            }
            System.Console.WriteLine();
        }
        //System.Console.WriteLine();
    }
    
}