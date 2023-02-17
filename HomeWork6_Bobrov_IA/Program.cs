#nullable disable
Console.Clear();

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

CountAnyNums(NumsFromString("Task_1"), 'P');


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = GetNum("b1", "Task2"); // В условии коэффициенты целые. Поэтому используем метод с возвращаемым типом int.
double k1 = GetNum("k1", "Task2"); // 
double b2 = GetNum("b2", "Task2");
double k2 = GetNum("k2", "Task2");
DotInterFind(b1, k1, b2, k2);

// Задача 44:выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

int numberTask3 = GetNum("size", "Taskk_3");
Console.WriteLine($"For {numberTask3} Numbers Fibonacci = " + string.Join(", ", GetNumsFibonacci(numberTask3)));

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
int[] NumsFromString(string task) // Метод принимает из консоли одну строку с целыми числами и возвращает массив чисел
{                                  // В дальнейшем можно продумать обработку ошибок ввода
    Console.WriteLine($"Enter numbers for {task} use (,) and Space: ");
    string numsInString = Console.ReadLine();
    string[] numbers = numsInString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int [numbers.Length];
    for(int i = 0; i < numbers.Length; i++)
    {
        result[i] = Convert.ToInt32(numbers[i]);
    }
    return result;
}

void CountAnyNums(int[] Arr, char mode) // Метод выводит в консоль количество определенных по условию чисел
{   
    int count = 0;
    string info = "info";
    foreach(int num in Arr)
    {   
        
        if(mode == 'E' && num % 2 == 0) {count++; info = "evened";} // четные
        if(mode == 'O' && num % 2 !=0) {count++; info = "odded";} // нечетные
        if(mode == 'P' && num >= 0) {count++; info = "positived";} // положительные, 0 учитывается
        if(mode == 'N' && num < 0) {count++; info = "negatived";}  // отрицательные
    }
    if (info != "info") System.Console.WriteLine($"Counter {info} numbers  = {count}");
    else System.Console.WriteLine("Counter not run");
}
int GetNum (string nameNum, string task) // Метод принимет целые числа с консоли
{
    System.Console.Write($"Enter {nameNum} for {task}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void DotInterFind (double b1, double k1, double b2, double k2) // Метод находит точку пересеченя двух прямых
{
    double dot1 = (b1-b2)/(k2-k1);
    double dot2 = k1*dot1+b1;
    System.Console.WriteLine($"Point intersection: ({dot1}; {dot2})");
}

int Fibonacci(int num)
{
    if (num <=1) return num;
    else return Fibonacci(num-1) + Fibonacci(num-2);
}

int[] GetNumsFibonacci(int size)
{
    int[] Result = new int [size];
    for (int i = 0; i < size; i++)
    {
        Result[i] = Fibonacci(i);
    }
    return Result;
}



