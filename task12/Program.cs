/*
12.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

System.Console.WriteLine("Введите два числа ");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    System.Console.WriteLine("да");
}
else 
{
    System.Console.WriteLine("Числа не кратные, остаток от деления " + number1 % number2);
}