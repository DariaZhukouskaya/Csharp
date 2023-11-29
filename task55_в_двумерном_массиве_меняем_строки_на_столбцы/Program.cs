/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это не возможно, программа должна вывести сообщение для пользователя.
Напимер задан массив:
1 4 7 2 
5 9 2 3
8 4 2 4 
5 2 6 7
В итоге получаем:
1 5 8 5 
4 9 4 2 
7 2 2 6
2 3 4 7
*/

// в больших проектах много строк и где то нужно будет использовать исходный массив, где то преобразованный массив
//если нам нужно будет переменную использовать еще где то в коде, то пишем через int , а если не используем больше нигде, то можно решать задачу и через void 


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

int[,] ReplaceRowsColumns(int[,] array) // интовый массив с названием array 
{
    int[,] result = CopyArray(array); // скопировали входящий массив и запомнили в переменную result;    если хоти сохранить исходный массив, то нужен copyArray в другой функции(как сдесь, хотя выше есть CopyArray)
    int temperary = 0; // завели переменную новую, куда будем сохранять необходимую нам переменную
    for (int i = 0; i < array.GetLength(0); i++) // пробегаем по всем строкам
    {
        for (int j = 0; j < i; j++) // пробегаем по всем столбцам
        {
            if (i != j)
            {
                temperary = result[i, j];
                result[i, j] = result[j, i];
                result[j, i] = temperary;
            }
        }
    }
    return result;
}

int userArrayRow = TakeEnteredNumber("Введите количестов строк и столбцов:");
int userArrayColumn = userArrayRow;
int userArrayStart = TakeEnteredNumber("Введите начало диапозона:");
int userArrayEnd = TakeEnteredNumber("Введите конец диапозона:");
int[,] user2DArray = GetRandom2DArray(userArrayStart, userArrayEnd, userArrayRow, userArrayColumn); // сделали массив со всех полученных данный

Print2DArray(user2DArray); //распечатываем наши данные, которые ввел пользователь

int[,] userArray2 = ReplaceRowsColumns(user2DArray);
System.Console.WriteLine();
Print2DArray(userArray2);