/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m, n);

void AkkermanFunction(int m, int n)   // вызов функции Аккермана
{
    System.Console.Write(Akkerman(m, n));
}

int Akkerman(int numM, int numN)    // функция Аккермана
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numN == 0 && numM > 0)
    {
        return Akkerman(numM - 1, 1);
    }
    else
    {
        return (Akkerman(numM - 1, Akkerman(numM, numN - 1)));
    }
}