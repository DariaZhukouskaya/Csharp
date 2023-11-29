/*
64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

System.Console.WriteLine("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());

void intN(int last)
{
    if (last >= 1)
    {
        System.Console.Write(last);
        intN(last - 1);
    }
    else;
        return;
}
intN(number);
System.Console.WriteLine();