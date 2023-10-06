/*
Задача 2. Название дня недели по заданному номеру.
*/

System.Console.WriteLine("Введите число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (userNumber1 == 2)
{
    System.Console.WriteLine("Вторник");
}
if (userNumber1 == 3)
{
   System.Console.WriteLine("Среда"); 
}
if (userNumber1 == 4)
{
    System.Console.WriteLine("Четверг"); 
}
if (userNumber1 == 5)
{
    System.Console.WriteLine("Пятница");
}
if (userNumber1 == 6)
{
   System.Console.WriteLine("Суббота"); 
}
if (userNumber1 == 7)
{
    System.Console.WriteLine("Воскресенье"); 
}
else 
{
System.Console.WriteLine("Нет такого дня недели");
}