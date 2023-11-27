/* 
25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Clear();
System.Console.WriteLine("Задай A");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай B");
int numB = Convert.ToInt32(Console.ReadLine());

void NatStep(int a, int b)
{
    double result = Math.Pow(a, b);
    System.Console.WriteLine(result);
}

NatStep(numA, numB);

/*void NatStep(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    System.Console.WriteLine(result);
}*/