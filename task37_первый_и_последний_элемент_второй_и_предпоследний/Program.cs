/*
37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3 (5 = 1*5, 8 = 2*4, 3 без пары)
[6 7 3 6] -> 36 21 (36 = 6*6, 21 = 7*3)
*/

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{

    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);

        if (i < arr.Length - 1) System.Console.Write(", ");// 5, 7, 1, 4

    }

    System.Console.Write("]");
}

int[] ProductArray(int[] pArr) // метод будет собирать и умножать пары чисел
{
    int[] result = new int[pArr.Length / 2]; //возвращаем массив int[]; pArr.Length/2 - половина размера исходного массива
    int sum = 0;
    for (int i = 0; i < pArr.Length / 2; i++) 
    {     //индекс 0        последнее число массива - i (и будет предпоследнее)
        sum = pArr[i] * pArr[pArr.Length - 1 - i]; // нулевой и последний индекс перемножаем и записываем результат в sum
        result[i] = sum; 
    }

    return result;
}

int[] userArray = GetRandomArray(6);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);