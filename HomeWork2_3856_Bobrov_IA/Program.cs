//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число для задания 1: ");
int numTask1 = Convert.ToInt32(Console.ReadLine());
int resultTask1 = -1;

if (numTask1 < 0) numTask1 *= -1;

 if (numTask1 >= 100 && numTask1 <= 999)
{
    resultTask1 = (numTask1 / 10) % 10;
    Console.WriteLine($"Вторая цифра числа = {resultTask1}");
}
else
{
    Console.WriteLine("Введенное число - не трехзначное");
}

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число для задания 2: ");
int numTask2 = Convert.ToInt32(Console.ReadLine());
int devider = 1;
int resultTask2 = -1;

if (numTask2 < 0) numTask2 *= -1;
int tempTask2 = numTask2;
if ( numTask2 > 99)
{
    while (tempTask2 > 999)
    {
        devider *= 10;
        tempTask2 /= 10;
    }
    resultTask2 = (numTask2 / devider) % 10;
    Console.WriteLine($"Третья цифра введенного числа = {resultTask2}");
}
else 
{
    Console.WriteLine($"Третьей цифры нет");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
 
Console.Write("Введите номер дня недели для задания 3: ");
int numTask3 = Convert.ToInt32(Console.ReadLine());

if (numTask3 > 0 && numTask3 < 8)
{
    if (numTask3 == 6 || numTask3 == 7)
    {
        Console.WriteLine("Да! Это выходной день");
    }
    else
    {
        Console.WriteLine("Нет! Это рабочий день");
    }
}
else
{
    Console.WriteLine("Введенное число не номер дня недели");
}