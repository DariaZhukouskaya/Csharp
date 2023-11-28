/*
46. Задайте двумерный массив размером m n, заполненый случайными целыми числами.
m = 3, n = 4
1 4 8 19
5 -2 33 -2
77 3 8 1
*/


int TakeInterNumber(string message) // для ввода чисел
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column]; //int[,] запятая это делитель; [row, column] через запятую понятно что двумерный массив идет
    for (int i = 0; i <row; i++) // массив для переборки row
    {
        for (int j = 0; j < column; j++) //массив для переборки column(это столбцы)
        {
            array[i, j] = new Random().Next(start, end + 1);  // 0 и 1 которые в скобках мы определили как row и column
        }
    }
    return array;
}

void Print2DArray(int[,] array) // выводим печать
{
    for (int i = 0; i < array.GetLength(0); i++) // 0 это количество строк
    {
        for (int j = 0; j < array.GetLength(1); j++) // 1 это количество столбцов
        {
        System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int userArrayRow = TakeInterNumber("Введите количество строк: ");
int userArreyColumn = TakeInterNumber("Введите количество столбцов: ");
int userArrayStart = TakeInterNumber("Введите начало диапозона: ");
int userArreyEnd = TakeInterNumber("Введите конец диапозона: ");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArreyEnd, userArrayRow, userArreyColumn);

Print2DArray(user2DArray);