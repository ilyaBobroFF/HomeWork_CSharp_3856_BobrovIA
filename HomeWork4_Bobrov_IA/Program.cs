{
    // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    // 3, 5 -> 243 (3⁵)
    // 2, 4 -> 16

    Console.Write("Введите число для возведения в степеть (задача №1): ");
    int numA = int.Parse(Console.ReadLine());

    Console.Write(" C показателем второго числа. Введите второе число (задача №1): ");
    int numB = int.Parse(Console.ReadLine());
    if (numB < 0)
    {
        numB *= -1;
        Console.WriteLine("Внимание! Изменен знак показателя степени с - на +");
    }

    int DegreeGet (int num1, int num2)
    {
        int degree = 1;
        for (int i = 1; i <= num2; i++)
        {
            degree *= num1;
        }
        return degree;
    }
    Console.WriteLine($"Ответ = {DegreeGet(numA, numB)}");
}
{
    // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    // 452 -> 11
    // 82 -> 10
    // 9012 -> 12
    
    Console.Write("Введите число для задачи №2: ");
    int num = Convert.ToInt32(Console.ReadLine());
    PrintSumNumbres(num);
    void PrintSumNumbres(int numbers)
    {
        if (numbers <= 0) numbers *= -1; 
        int sum = 0;
        while (numbers > 0)
        {
            
             sum += numbers % 10;
             numbers /= 10;
        }
        Console.WriteLine($"Количество цифр в веденом числе = {sum}");
    }

}
{
    //  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    //  1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    // 6, 1, 33 -> [6, 1, 33]

       int[] GetArrayNum()
    {
        int size = 8; // Можно перенести в параметр метода и вводить количество элементов
        int[] Arr = new int [size];
        for (int i = 0; i < size; i++)
        {
            Arr [i] = new Random().Next(0, 25); // Диапазон возможных чисел по условию не указан
        }
        return Arr;
    }
    void PrintArray(int []Array)
    {
        for (int i =0; i <= Array.Length - 2; i++)
        {
            Console.Write(Array[i] + ", ");
        }
        Console.Write(Array[Array.Length - 1]);
    }

    Console.WriteLine("Происходит получение массива чисел для задачи №3");
    int [] numbers = GetArrayNum();
    Console.Write("Полученный массив: ");
    PrintArray(numbers);
    
}
