/*24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

System.Console.WriteLine("Введите число ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Sum(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result = result + i;
    }
    return result;
}
int userSum = Sum(userNum);
System.Console.WriteLine(userSum);

/*
Console.Clear();
  //Взять число и найти его квадрат и вычеслить корень из получившегося числа
 int usera = 4; 
 double Num (int a) 
{
    double result = Math.Pow(a, 2); // с 13 по 17 строку, функция возведения в квадрат
    return result; 
}
 void Num1(int a)  //функция void ничего не возвращает и работает внутри себя
{
    double result = Math.Pow(a, 2); // возвращается за функцию
    System.Console.WriteLine(result);;  
}
 double userresult = Num(usera);
 double root = Math.Sqrt(userresult);
 System.Console.WriteLine(root);
 System.Console.WriteLine(userresult);
 Num1(usera);
 System.Console.WriteLine(result);
 */


/*
int a = 4; 
int Num (int a)  //я завожу функцию, которая заводит мне значение Num
{
    int result = a + a; // завожу переменную result и считаю его
    return result;   // Одна функция - один return. Возвращаем result 
}
System.Console.WriteLine(result);
*/


/*
int b = 4; 
double Num (int a)  
{
    double result = Math.Pow(a, 2); 
    return result;   
}
System.Console.WriteLine(result);
*/



/*
void Num(int a)  // В void будет cw на 59 строке, а не return 
{
     double result = Math.Pow(a, 2); 
     System.Console.WriteLine(result);;  
}
*/