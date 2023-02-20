#nullable disable
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.WriteLine("Task_1");
double[,] matrixTask1 = MakeMatrixDouble();
System.Console.WriteLine();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.WriteLine("Task_2"); 
int row = GetNumConsole("rows size", "Task_2");
int column = GetNumConsole("columns size", "Task_2");
int minValue = GetNumConsole("minValue", "Task_2");
int maxValue = GetNumConsole("maxValue", "Task_2");
int numberCheck = GetNumConsole("numberCheck", "Task_2");
int[,] matrixForCheck = MakeMatrixInt(row, column, minValue, maxValue);
PrintMatrix(matrixForCheck);
CheckMatrix(matrixForCheck, numberCheck);
System.Console.WriteLine();

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.WriteLine("Task_3");
row = GetNumConsole("rows size", "Task_3");
column = GetNumConsole("columns size", "Task_3");
minValue = GetNumConsole("minValue", "Task_3");
maxValue = GetNumConsole("maxValue", "Task_3");
matrixForCheck = MakeMatrixInt(row, column, minValue, maxValue);
PrintMatrix(matrixForCheck);
AverageNumberInRow(matrixForCheck);
System.Console.WriteLine();

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

row = GetNumConsole("rows size", "Task_4");
column = GetNumConsole("columns size", "Task_4");
PrintMatrix(FillMatrixSpiral(row, column));


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

double[,] MakeMatrixDouble() // Метод создающий двухмерный массив вещественных и сразу выводящий его в консоль
{
    int row = GetNumConsole("rows size", "Task_1");
    int column = GetNumConsole("columns size", "Task_1");

    double[,] matrix = new double [row, column];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = GetRandomNumber();
            System.Console.Write(matrix[i, j] + " ");
        } 
        System.Console.WriteLine();
    }
    return matrix;
}

double GetRandomNumber() // Метод передает произвольное число с запятой. Диапазон пока фиксированный
{
    double number = Convert.ToDouble(new Random().Next(-99, 100))/10;
    return number;
}
int GetNumConsole (string nameNum, string task) // Метод принимет целые числа с консоли
{
    System.Console.Write($"Enter {nameNum} for {task}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] MakeMatrixInt(int row, int column, int minValue, int maxValue) // Метод создающий двухмерный массив целых чисел
{
    int[,] matrix = new int [row, column];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue+1);
            //System.Console.Write(matrix[i, j] + " ");
        } 
        //System.Console.WriteLine();
    }
    return matrix;

}
void CheckMatrix(int[,] matrix, int numberCheck)          // Проверяет наличие введенного числа в двухмерном массиве
{
    bool checkOk = false;
    for(int i = 0; i < row; i++)
    {
        int j = 0;
        for (; j < column; j++)
        {
            if (matrix[i, j] == numberCheck) {checkOk = true; break;}
        } 
        if(checkOk) break;
    }
   
    System.Console.WriteLine($"Number {numberCheck} in matrix is {checkOk}");
}

void PrintMatrix(int[,] matrix) // Метод отображающий массив в консоли
{
    System.Console.WriteLine($"Input matrix({matrix.GetLength(0)}x{matrix.GetLength(1)}) = ");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        } 
        System.Console.WriteLine();
    }
    
}


void AverageNumberInRow(int[,] matrix)                 // Метод считает среднее арифметическое элементов каждого столбца. Можно вывести расчеты в консоль для проверки
{
    double[] result = new double [matrix.GetLength(1)];
    double averagerow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        averagerow = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            averagerow += (double) matrix[i, j];
            // System.Console.Write($"i = {i} : j = {j} :"); // вывод позиции элемента
            // System.Console.WriteLine("matrix = " + matrix[i,j]); // вывод значения элемента
        }
        result[j] = Math.Round(averagerow / matrix.GetLength(0), 2);
        // System.Console.WriteLine("result = " + result[j]); // вывод среднего по текущему столбцу
        // System.Console.WriteLine();
    } 
    System.Console.WriteLine("Average sum numbers for each row = " + string.Join("; ", result));
    System.Console.WriteLine();
}

int[,] FillMatrixSpiral(int row, int column)  // Заполняет спирально числами по порядку матрицу
{
    int [,] matrix = new int [row, column];
    int size = row * column;
    int cover = 0;
    int step = 1;
    int i = 0;
    int j = 0;
    while(step < size)
    {
       while(j < column - cover-1) 
        {
            matrix[i, j++] = step++;
            if(cover != 0 && matrix[i, j+1] > 0) break;
        }
        while(i < row - cover - 1)
        {
            matrix[i++, j] = step++;
            if(cover != 0 && matrix[i+1, j] > 0) break;
            
        }
        while (j > cover)
        {
            matrix[i, j--] = step++;
            if(cover != 0 && matrix[i, j-1] > 0) break;   
        }
        cover++;
        while (i > cover)
        {
            matrix[i--, j] = step++;
            if(cover != 0 && matrix[i-1, j] > 0) break;   
        }
    }
    for (int n = 0; n < row; n++)
    {
        for (int m = 0; m < column; m++)
        {
            if (matrix[n, m] ==0) matrix[n, m] = step;
        }
    }
    return matrix;
}
    

