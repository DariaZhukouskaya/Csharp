/*
Задача 7. Напииште программу, которая принимает на входе трехзначное число, а на выходе показывет последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

System.Console.WriteLine("Введите число: ");
int userNamber1 = Convert.ToInt32(Console.ReadLine());
int result = userNamber1 % 10;
System.Console.WriteLine(result);