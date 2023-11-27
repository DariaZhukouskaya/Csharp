/*
Задача 34. Напишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.
*/

int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int CountEvenElements(int[] array)
{
    int count = 0; // счетчик который высчитывает четный элемент
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0);
        count++;
    }
    return count;
}

void PrintArray(int[] arrayOne)
{
    System.Console.WriteLine("Массив: ");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1);
        System.Console.Write("\t");
    }
    System.Console.WriteLine();
    System.Console.Write($"Количество четных элементов: {CountEvenElements(arrayOne)}");
}

int Length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапозона случайного числа: ");
int max = Prompt("Конечное значение для диапозона случайного числа: ");
int[] array = GenerateArray(Length, min, max);
PrintArray(array);