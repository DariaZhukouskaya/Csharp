/*
30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
*/


System.Console.WriteLine();

int[] GetRandArray(int size) // размер массива запрашиваем у поьзователя
{
    int[] array = new int[size]; //создали пустой массив 
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(0, 2); //ложим рандомное число в наш массив
    }
    return array; //ф вункции всегда return
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) //arr.Length автоматом определяет длину массива
    {
        System.Console.Write($"{arr[i]}, "); // так как void на 18 строке
    }
}

int[] userArray = GetRandArray(9);
PrintArray(userArray);