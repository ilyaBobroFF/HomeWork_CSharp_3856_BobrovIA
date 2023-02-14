#nullable disable

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

CountAnyNums(NumsFromString("Task_1"), 'P');


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = GetNumD("b1", "Task2");
double k1 = GetNumD("k1", "Task2");
double b2 = GetNumD("b2", "Task2");
double k2 = GetNumD("k2", "Task2");
DotInterFind(b1, k1, b2, k2);



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
    if (info != "info") System.Console.WriteLine($"Counter {info} number  = {count}");
    else System.Console.WriteLine("Counter not run");
}
double GetNumD (string nameNum, string task) // Метод принимет числа double с консоли
{
    System.Console.Write($"Enter {nameNum} for {task}: ");
    double number = double.Parse(Console.ReadLine());
    return number;
}

void DotInterFind (double b1, double k1, double b2, double k2) // Метод находит точку пересеченя двух прямых
{
    double dot1 = (b1-b2)/(k2-k1);
    double dot2 = k1*dot1+b1;
    System.Console.WriteLine($"Point intersection: ({dot1}; {dot2})");
}