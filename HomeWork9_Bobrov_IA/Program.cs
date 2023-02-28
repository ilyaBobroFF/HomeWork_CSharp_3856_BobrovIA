// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
int number = GetNumber("number", "Task_1");
System.Console.WriteLine(NaturalNumbers(number));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = GetNumber("number M", "Task_2");
int n = GetNumber("number N", "Task_2");
if (m > n )
{
    System.Console.WriteLine("Error enter numbers");
}
else
{
    int sum = SumNumbers(m, n);
    System.Console.WriteLine($"Sum numbers from {m} to {n} = {sum}");
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

m = GetNumber("number M", "Task_3");
n = GetNumber("number N", "Task_3");
if (n < 0 || m < 0 )
{
    System.Console.WriteLine("Enter positive numbers");
}
else 
{
    decimal result = Akkerman(m, n);
    System.Console.WriteLine($"Result functon Akkerman for ({m}, {n}) = {result}");
}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
int NaturalNumbers(int number)  // Выводит натуральные числа от N до 1
{
    if (number == 1) return 1;
    System.Console.Write(number + ", ");
    number = NaturalNumbers(number - 1);
    return number;
}

int SumNumbers(int m, int n) // Метод считает сумму чисел от М до N
{
    if(m==n) return n;
    return m + SumNumbers(m+1, n);
}
int GetNumber (string nameNum, string task) // Метод передает переменной значение с консоли
{
    System.Console.Write($"Enter {nameNum} for {task}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Akkerman (int m, int n) // Вычисляет функцию Аккермана 
{
    if (m==0) return n + 1;
    else if ( n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else return Akkerman(m - 1, Akkerman(m, n-1)); 
}