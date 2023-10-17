/*
19. Написать программу, которая принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.

Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.

Для остальных чисел вернуть True или False.

14212 -> False
12821 -> True
234322 -> Число не пятизначное False
*/

System.Console.WriteLine("Введите пятизначное число: ");
int a, b, d, e;
int number = Convert.ToInt32(Console.ReadLine());
a = number / 10000;         //первая цифра числа
b = (number / 1000) % 10;   //вторая цифра числа
d = (number / 10) % 10;     //предпоследняя цифра числа
e = number % 10;            //последняя цифра числа

if(a == e && b == d)
{
  System.Console.WriteLine("Число палиндром");
}
else
{
  System.Console.WriteLine("Число не палиндром");
}
if (number > 99999)
{
  System.Console.WriteLine("Число не пятизначное");
}


/*int UserReverse(int a)
{
  int revN = 0;
  for (int i = 0; i >0; i /= 10)
  {
    revN = revN * 10 + i % 10;
  }
  return revN;
}

void Result(int a, int b)
{
  if (a==b) System.Console.WriteLine("Yes");
  else System.Console.WriteLine("No");
}

System.Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int revN = UserReverse(n);
Result(n, revN);*/