/*
40. Напииште программу, которая принимает на вход три числа и проверяет, может ли 
существовать треугольник со сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух 
других сторон.
*/

System.Console.WriteLine("ВВедите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("ВВедите число B: ");
int userB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("ВВедите число C: ");
int userC = Convert.ToInt32(Console.ReadLine());

bool Triagle(int a, int b, int c) //bool: либо да либо нет
{
    bool result = false;
    if (a + b > c && a + c > b && b + c > a)
    {
        result = true;
    }
    return result;
}
System.Console.WriteLine(Triagle(userA, userB, userC));
