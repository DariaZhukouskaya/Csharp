/*
Задача 2. Напииште программу, в которой принимает на вход три числа и выдаёт максимальное из этих чисел.
*/ 

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) 
{
    Console.WriteLine($"Mаксимальное число{number1}");
}
else 
{
    Console.WriteLine($"Mаксимальное число{number2}");
}
if (number2 > number3) 
{
    Console.WriteLine($"Mаксимальное число{number2}");
}
else 
{
    Console.WriteLine($"Mаксимальное число{number3}");
}
