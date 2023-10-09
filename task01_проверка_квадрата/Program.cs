/*
Задача 1. Проверить два веденных числа - квадрат ли это?
*/

System.Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == userNumber2 * userNumber2)
{
    System.Console.WriteLine($"Да, перывое число: {userNumber1} квадрат второго: {userNumber2}");
}
else
{
    System.Console.WriteLine($"Нет, число  {userNumber1} не квадрат {userNumber2}");
}
