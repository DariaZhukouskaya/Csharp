/*
Задача 39.
Напииште программу, которая перевернет одномерный массив (последний элемент будет на первом месте, 
а первый на последнем и т.д.)
*/

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int Promp(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) ;
        System.Console.Write(", ");
    }
    System.Console.Write("]");
}

void Reverse(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[array.Length - 1 - i];  // здесь находится последний массив
        array[array.Length - 1 - i] = array[i]; // последний массив перемещаем в первый
        array[i] = temp;
    }

}

int size = Promp("Задай размер массива: ");
int[] userArray = GetRnd(size);
PrintArray(userArray); //печатаем массив
System.Console.WriteLine(); //пустая строка
Reverse(userArray); //проходит через метод void где у нас Reverse
PrintArray(userArray); //печатаем заново и он уже измененн
