/*
65. Задайте значение М и N. 
Напишите программу, которая выведет все натуральные исла в промежутке от М до N.
*/

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void intN(int first, int last)
{
    if (last >= first)
    {
        System.Console.Write(first + " ");
        intN(first +1, last);
    }
    else;
        return;
}
intN(number1, number2);