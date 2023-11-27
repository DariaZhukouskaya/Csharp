/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

/*int Prompt(string massage)
{
    System.Console.Write(massage);
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

void PrintArray(int[] array)
{
    int pozitive = 0;
    int negative = 0;

    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }
        if (array[i] > 0)
        {
            pozitive = pozitive + array[i];
        }
        else
        {
            negative = negative + array[i];
        }
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма положительных чисел:\t {pozitive}");   //\t это длинный пробел делает в терминале
    System.Console.WriteLine($"Сумма отрицательных чисел:\t{negative}");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значене для дапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);*/

int[] GetRandomArray(int start, int end, int lenght) // обьявление функции заполнения случайными цифрами
{
    int[] array = new int[lenght]; // создаем новый массив new int [lenght]
    for (int i = 0; i < lenght; i++)  // от -9 до 9 заполняет
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] array) // возвращает напичатанную строку
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++) // lenght выводит на печать
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

int TakeEntNum(string message) // выводит сообщение на экран и 
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumPositiveNum(int[] array)  // функция подсчета положительных чисел
{

    int result = 0;
    for (int i = 0; i < array.Length; i++) // перебираем все показателт на положительные числа
    {
        if (array[i] > 0) result += array[i]; // все положительные цифры складываем в result 
    }
    return result;
}

int SumNegativeNum(int[] array) // подсчет отритцательных чисел, меньше 0 которые
{

    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) result += array[i];
    }
    return result;
}

int userArraySize = TakeEntNum("Please, enter array size:"); // забери число 
int userArrayStart = TakeEntNum("Please, enter array start number range:"); // выводим и забираем число с которой долдно генерироватся со случайным числом
int userArrayEnd = TakeEntNum("Please, enter array end number range:");

int[] userArray = GetRandomArray(userArrayStart, userArrayEnd, userArraySize); // генерируем случайный массив
PrintArray(userArray); // проверяем функцию

int posArraySum = SumPositiveNum(userArray); // сумма позитивных чисел
int negArraySum = SumNegativeNum(userArray); // сумма негативных чисел

System.Console.WriteLine($"Sum of positive numbers {posArraySum}, sum of negative numbers {negArraySum}.");