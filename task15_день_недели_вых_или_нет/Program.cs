/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 == 1)
{
    System.Console.WriteLine("Понедельник");
    System.Console.WriteLine("Нет");
}
if (userNumber1 == 2)
{
    System.Console.WriteLine("Вторник");
    System.Console.WriteLine("Нет");
}
if (userNumber1 == 3)
{
   System.Console.WriteLine("Среда"); 
   System.Console.WriteLine("Нет");
}
if (userNumber1 == 4)
{
    System.Console.WriteLine("Четверг"); 
    System.Console.WriteLine("Нет");
}
if (userNumber1 == 5)
{
    System.Console.WriteLine("Пятница");
    System.Console.WriteLine("Нет");
}
if (userNumber1 == 6)
{
   System.Console.WriteLine("Суббота"); 
   System.Console.WriteLine("Да");
}
if (userNumber1 == 7)
{
    System.Console.WriteLine("Воскресенье");
    System.Console.WriteLine("Да"); 
}
