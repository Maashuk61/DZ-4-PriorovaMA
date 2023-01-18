// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

void FillArray(int[] col)
{
    int index = 0;
    int length = 8;
    while (index < length)
    {
        int number = ReadNumber("Введите число: ");
        col[index] = number;
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection[position]);
        position ++;
    }
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int [8];
FillArray(array);
Console.WriteLine();
PrintArray(array);