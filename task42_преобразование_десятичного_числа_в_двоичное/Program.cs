/*
42. Напииште программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

int UserInOut(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string Conv(int number) // number = 3 
{
    string result = "";  
    int temp = 0;  
    for (int i = number; i > 0; i /= 2) // повторяем пока i(=3) не сотрется в 0: i = 3; 3 > 0; 3 / 2 = 1 остаток 1
    {
        temp = i % 2; // 3/2=1 остаток 1
        result = temp + result; 
    }   
    return result;
}

int uNum = UserInOut("Введите число: ");
System.Console.WriteLine(Conv(uNum));