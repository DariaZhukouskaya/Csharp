/*
задача 38.
Напишите программу для работы с массивом вещественных чисел.
*/

int Promp(string massage) // Promp запрашивает ввод чисел по очередности
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

double[] GenerateArray(int size, int minValue, int maxValue) //метод создания массива вещественных чисел
{
    double[] array = new double[size]; // создали массив типа double
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (maxValue + 0.01 - minValue) + minValue, 2); //когда создаем рандомные числа типа double, то они рандомятся от 0 до 1
    }                                                 // если ставить 1, то покажет 10.99 и это уже больше 10
    return array;
}

double FindMax(double[] array) // ищем макс число в массиве
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++) //пробегаемся по всему массиву
    {
        if (max < array[i]) // если мах меньше чем число в массиве под текущем индексом, то перезаписываем мах
            max = array[i];
    }
    return max;
}

double FindMin(double[] array) // ищем мин число в массиве
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array) // находим разницу между мин и мах
{
    double result = FindMax(array) - FindMin(array);
    return result;
}

void PrintArray(double[] arrayOne)
{
    System.Console.WriteLine("Массив: ");
    System.Console.Write("[");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1) ;
        System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    System.Console.WriteLine($"Минимальный элемент: {FindMin(arrayOne)}");
    System.Console.WriteLine($"Максимальный элемент: {FindMax(arrayOne)}");
    System.Console.Write($"Разница между максимальным и минимальным элементами = {CalcDifferenceBetweenMaxMin(arrayOne)}");
}

int Length = Promp("Длина массива: ");
int min = Promp("Минимальное значение: ");
int max = Promp("Максимальное значение: ");
double[] array = GenerateArray(Length, min, max);
PrintArray(array);