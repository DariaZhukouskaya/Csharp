/*
53. Задайте двумерный массив. Напииште программу, которая поменяет местами первую и
последнюю строку массива. например:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/

int TakeEnteredNumber(string message)  // ввод чисел пользователя
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] GetRandom2DArray(int start, int end, int row, int column) // задаем массиву значение, которое вводит пользователь
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

int[,] CopyArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];    // задаем размер
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i, j] = array[i, j]; // копируем каждый элемент массива в result
        }
    }
    return result;
}

int[,] ChangeRows(int[,] array) // получаем новый массив (меняем последнюю строку и первую)
{
    int temperary = 0;
    int[,] result = new int[array.GetLength(0), array.GetLength(1)]; //обращаемся к данным из массива array в функции void Print2DArray
    result = CopyArray(array);
    for (int j = 0; j < array.GetLength(1); j++) // перебираем нашу первую и последнюю строку
    {
        temperary = result[0, j];
        result[0, j] = result[array.GetLength(0) - 1, j];
        result[array.GetLength(0) - 1, j] = temperary;
    }
    return result;
}

void Print2DArray(int[,] array) // вывод печати
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

int userArrayRow = TakeEnteredNumber("Введите количестов строк:");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов:");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn);

Print2DArray(user2DArray); //распечатываем наши данные, которые ввел пользователь

int[,] userArray2 = ChangeRows(user2DArray);
System.Console.WriteLine();
Print2DArray(userArray2);