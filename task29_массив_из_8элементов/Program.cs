﻿/*
29. Напишите программу, которая берет массив у пользователя, его размер и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
6, 1, 33 -> [6, 1, 33]
*/


int[] GetArray(int start, int end, int size)  //запрашиваем у пользователя диапозон массива: первая функция наполняет массив, вторая выводит на экран
{
    int[] array = new int[size]; //чтоб наполнить int[] array мы заходит в функцию
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(start, end + 1); //начало и конец задается от пользователя
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);   //[5, 7, 1, 4] - размер
        if (i < arr.Length - 1)         // 0, 1, 2, 3 - массив
            System.Console.Write(", ");
    }
    System.Console.Write("]");
    Console.ResetColor();
}

System.Console.WriteLine("Задай диапазон массива от:");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай диапазон массива до:");
int userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай размер массива:");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(userStart, userEnd, userSize);  // вызываем функцию
PrintArray(userArray);  // печатаем функцию (void метод)