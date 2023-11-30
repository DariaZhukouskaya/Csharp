/*Задача 48. Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

void Main(string[] args)
{
    int m = 3;   //задайте размер m
    int n = 3;   //задайте размер n
    int[][] arr = new int[3][];
    for (int i = 0; i < arr.Length; i++) //первый цикл for; i отвечает за строки i=0
    {
        arr[i] = new int[3];
        for (int j = 0; j < arr[i].Length; j++) // второй цикл for; о отвечает за столбцы j=0
        {
            arr[i][j] = i + j; // в i j складыввет i+о то есть 0 индекс=0, на втором круге j=1(индекс 1); на втором круге получится 0+1
        }

    }
    PrintArr(arr);
}
void PrintArr(int[][] arr)
{
    foreach (var row in arr)
    {
        System.Console.WriteLine($"[{string.Join(" ", row)}]");
    }
}