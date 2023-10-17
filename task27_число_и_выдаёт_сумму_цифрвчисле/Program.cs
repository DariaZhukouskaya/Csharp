/*
27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumNumber(int a)
{
    int result = 0;
    for (int i = a; i > 0; i /= 10)  // a делим на 10 каждый круг
    {
        result = result + i % 10;   // result = 0, 0 + i +% 10
    }
    return result;
}
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int userRes = SumNumber(num);
System.Console.WriteLine(userRes);