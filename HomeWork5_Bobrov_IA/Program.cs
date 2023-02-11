// Задача 34(1): Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

{  // Выполнение задачи №1
    Console.WriteLine();
    int[] Numbers = GetArrayRandNum(10, 100, 999, "Задачи №1");           
    int countEven = CounterEvenOdd(Numbers, "Even");
    Console.WriteLine("Количество четных элементов в массиве = "+ countEven);
    Console.WriteLine();
    Console.WriteLine();
}
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

{ // Выполнение задачи №2
    Console.WriteLine();
    int[] Numbers = GetArrayRandNum(8, -100, 100, "Задачи №2"); 
    int countOdd = CounterEvenOdd(Numbers, "Odd");
    Console.WriteLine("Количество нечетных элементов в массиве = "+ countOdd);
    Console.WriteLine();
    Console.WriteLine();
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

{ // Выполнение задачи №3
    Console.WriteLine();
    double[]Numbers = GetArrayModificy(10, 1, 100, "Задачи №3"); // Выбор испоользования метода получения произвольных чисел
    // double[] Numbers = GetArrayUser("Задачи №3");             // или заданием вручную
    double different = DiffMaxMin(Numbers);
    Console.WriteLine("Разница между макс и мин элементом = " + different);
    Console.WriteLine();
}

int[] GetArrayRandNum(int size, int minEl, int maxEl, string task) // Метод для получения массива из случайных чисел
    {
        int[] Arr = new int [size];
        for (int i = 0; i < size; i++)
        {
            Arr [i] = new Random().Next(minEl, maxEl+1);
        }
        Console.WriteLine($"Получили массив из {size} элементов для {task}");
        Console.WriteLine("Полученный массив = "+ String.Join(", ", Arr));
        
        return Arr;
    }

int CounterEvenOdd(int[] Arr, string evenOrOdd) // Метод для подсчета количества четных или нечетных элементов
{   
    int count = 0;
    foreach(int num in Arr)
    {
        if (num % 2 == 0 && evenOrOdd == "Even") count++;
        if (num % 2 != 0 && evenOrOdd == "Odd") count++;
    }
    return count;
}

double[] GetArrayModificy(int size, int minEl, int maxEl, string task) // Метод для получения массива из случайных чисел (изменен для получения вещественных чисел)
{
    double [] Arr = new double  [size];
    for (int i = 0; i < size; i++)
    {
        Arr [i] = Convert.ToDouble(new Random().Next(minEl*1000, (maxEl+1)*1000)) / 1000;
    }
    Console.WriteLine($"Получили массив из {size} элементов для {task}");
    Console.WriteLine("Полученный массив = "+ String.Join(", ", Arr));
    
    return Arr;
}

double DiffMaxMin(double[] Arr) // Метод вычисления разницы между минимальным и максимальным элементом
{
    double max = Arr[0];
    double min = Arr[0];
    foreach (var element in Arr)
    {
        if (element > max) max = element;
        if (element < min) min = element;
    }
    Console.WriteLine("Максимальный элемент = " + max);
    Console.WriteLine("Минимальный элемент = " + min);
    max -= min;
    return max;
}

// double[] GetArrayUser(string task) // Метод для получения массива при задании пользователем
// {
//     Console.Write($"Введите длину массива для {task}: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     while (size <= 1)
//         {
//             Console.Write("He верно указана длина массива. Повторите ввод: ");
//             size = Convert.ToInt32(Console.ReadLine());
//         } 
    
//     double[] Arr = new double [size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write($"Введите элемент массива используя (,) c индексом {i}: ");
//         Arr [i] = Convert.ToDouble(Console.ReadLine());
//     }
//     Console.WriteLine($"Получили массив из {size} элементов для {task}");
//     return Arr;
// }
    
