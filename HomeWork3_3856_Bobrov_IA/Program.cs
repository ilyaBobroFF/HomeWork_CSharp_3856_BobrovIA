// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число для задачи №1");
int numTask1 = Convert.ToInt32(Console.ReadLine());
if (numTask1 < 0) numTask1 *= -1;
while (numTask1 > 99999 || numTask1 < 10000) // Принимается только пятизначное число по условию задачи
{
    Console.WriteLine("Неверный ввод! Введите пятизначное число повторно");
    numTask1 = Convert.ToInt32(Console.ReadLine());
    if (numTask1 < 0) numTask1 *= -1;
}

int length = 1;
int numTemp1 = numTask1;
int step = 1;

while (numTemp1 > 9)
{
    numTemp1 /= 10;
    length++;
}
    while (numTask1 > 10)
    {
        int devider = Convert.ToInt32(Math.Pow(10, (length - step)));
        // System.Console.Write($"Цифра слева = {numTask1 / devider}"); // Вывод сравниваемых цифр на каждой итерации
        // System.Console.WriteLine($" Цифра справа = {numTask1 % 10}");
        if ((numTask1 / devider) == (numTask1 % 10))
        {
            step += 2;
            numTask1 -= devider * (numTask1 / devider); // Отбрасывание крайней цифры слева
            numTask1 /= 10; // Отбрасывание крайней цифры справа
        }
        else
        {
            Console.WriteLine("Введенное число не палиндром");
            break;
        }
    }    
    if (numTask1 <= 9) Console.WriteLine("Это число палиндром");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите кординату Х первой точки для задачи №2: ");
double num1X = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату Y первой точки для задачи №2: ");
double num1Y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату Z первой точки для задачи №2: ");
double num1Z = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите кординату Х второй точки для задачи №2: ");
double num2X = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату Y второй точки для задачи №2: ");
double num2Y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кординату Z второй точки для задачи №2: ");
double num2Z = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((num2X-num1X), 2) + Math.Pow((num2Y-num1Y), 2) + Math.Pow((num2Z-num1Z), 2));

Console.WriteLine("Растояние между точками = " + result);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число для задания №3: ");
int numTask3 = Convert.ToInt32(Console.ReadLine());
int stepTask3 = 1;
int znak = 1;
while(numTask3 == 0)
{
    Console.Write("Введен 0. Повторите ввод: ");
    numTask3 = Convert.ToInt32(Console.ReadLine());
}
if (numTask3 < 0)
{
    znak = -1;
    numTask3 *= -1;
}
while (stepTask3 < numTask3)
{
    Console.Write(Math.Pow(stepTask3*znak, 3) +", ");
    stepTask3++;
}
Console.WriteLine(Math.Pow(stepTask3*znak, 3));