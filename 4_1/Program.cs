// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ReadNumberA(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ReadNumberB(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiate(int A, int B)
{
    int length = 1;
    int result = A;
    while (length < B)
    {
        result = result * A;
        length++;
    }
    return result;
}

int numberA = ReadNumberA("Введите число А: ");
int numberB = ReadNumberB("Введите число В: ");
int res = Exponentiate(numberA, numberB);
Console.WriteLine (res);