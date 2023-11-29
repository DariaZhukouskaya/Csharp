/*
57. Составить частотный словарь элементов двухмерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
9 встречается 3 раз

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раз
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раз
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

void PrintCount(int[,] array) // внутри двумерный массив
{
    for (int k = 0; k <= FindMax(array) + 1; k++)
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
         for (int j = 0; j < array.GetLength(1); j++)
            {
            
                if(k == array[i,j]) count++;
            }
        }
        System.Console.WriteLine($"Число {k} встречается {count} раза.");
    }
}

int FindMax(int[,] array) // ищем макс число в массиве
{
    int max = 0;
    for (int i = 0; i < array.GetLength(0); i++) //пробегаемся по всему массиву
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] > max) max = array[i,j];
        }
    }
    return max;
}

int userArrayRow = TakeEnteredNumber("Введите количестов строк: ");
int userArrayColumn = TakeEnteredNumber("Введите количестов столбцов: ");
int userArrayStart = TakeEnteredNumber("Введите начало диапозона: ");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона: ");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn); // сделали массив со всех полученных данный

Print2DArray(user2DArray); //распечатываем наши данные, которые ввел пользователь
PrintCount(user2DArray);