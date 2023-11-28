/*
Задача 36. 
Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.
*/

int Promp(string massage)
{
    System.Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) //находим все нечетные 
    { 
        sum = sum + array[i]; //суммируем 
    }
    return sum;
}

void PrintArray(int[] arrayOne)
{
    System.Console.WriteLine("Массив: ");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if(i < arrayOne.Length - 1);
        System.Console.Write("\t");
    }
    System.Console.WriteLine();
    System.Console.Write($"Сумма нечетных элементов: {SumOddElements(arrayOne)}");
}

int Length = Promp("Длина массива: ");
int min = Promp("Минимальное значение: ");
int max = Promp("Максимальное значение: ");
int[] array = GenerateArray(Length, min, max);
PrintArray(array);