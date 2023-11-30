/*
50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 и 2 -> 2
1 и 7 -> такого числа в массиве нет*/


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}


int[,] GetRandom2DArray(int start, int end, int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

bool CheckPosition(int row, int column, int[,] array)
{
    if (row < array.GetLength(0) && column < array.GetLength(1)) return true;
    else return false;
}

int FindIndex(int row, int column, int[,] array)
{
    int result = 0;
    if (CheckPosition(row, column, array) == true)
    return result = array [row, column];
    else false;
}



int userArrayRow = TakeEnteredNumber("Введите количестов строк: ");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов: ");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона: ");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона: ");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray);
System.Console.WriteLine(FindIndex(TakeEnteredNumber("Введите строку для нахождения значения в матрице:"), TakeEnteredNumber("Введите строку для нахождения значения в матрице: "), user2DArray));
