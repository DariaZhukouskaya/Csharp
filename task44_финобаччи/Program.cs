/*
44. Не используя рекурсию, выведите превые N чисел Финобаччи. 
Первые два числа Финобаччи 0 и 1.
если N = 5 -> 0 1 1 2 3 
если N = 3 -> 0 1 1
если N = 7 -> 0 1 1 2 3 5 8
Финобаччи это к каждому послед числу прибавляется предыдущее(0+1=1; 1+1=2; 1+2=3; 2+3=5; 3+5=8)
*/


System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N<1)
{
    System.Console.WriteLine("Введите число: ");
    return;
}

int first = 0;
int second = 1;
System.Console.WriteLine("Первые " + N + "чисел Финобаччи: ");

if (N >= 1)
{
    System.Console.Write(first);
}
if (N >= 2)
{
    System.Console.Write(", " + second);
}
for (int i = 3; i <= N; i++)
{
    int next = first + second;
    System.Console.Write(", " + next);
    first = second;
    second = next;
}

System.Console.WriteLine();