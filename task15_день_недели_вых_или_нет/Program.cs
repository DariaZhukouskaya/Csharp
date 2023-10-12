/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Введите число: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 1)
{
    System.Console.WriteLine("Понедельник");
    System.Console.WriteLine("Нет");
}
if (dayNumber == 2)
{
    System.Console.WriteLine("Вторник");
    System.Console.WriteLine("Нет");
}
if (dayNumber == 3)
{
   System.Console.WriteLine("Среда"); 
   System.Console.WriteLine("Нет");
}
if (dayNumber == 4)
{
    System.Console.WriteLine("Четверг"); 
    System.Console.WriteLine("Нет");
}
if (dayNumber == 5)
{
    System.Console.WriteLine("Пятница");
    System.Console.WriteLine("Нет");
}
if (dayNumber == 6)
{
   System.Console.WriteLine("Суббота"); 
   System.Console.WriteLine("Да");
}
if (dayNumber == 7)
{
    System.Console.WriteLine("Воскресенье");
    System.Console.WriteLine("Да"); 
}
if (dayNumber <1 || dayNumber > 7)
{
     System.Console.WriteLine("Нет такого дня недели");
}