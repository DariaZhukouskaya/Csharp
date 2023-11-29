/*
Задача 66. Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


System.Console.WriteLine("Введите значение М: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

SummaMToN(m, n);

void SummaMToN(int m, int n)    // вызов функции сумма чисел от M до N
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)      // функция сумма чисел от M до N
{
    int result = m;
        if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}
