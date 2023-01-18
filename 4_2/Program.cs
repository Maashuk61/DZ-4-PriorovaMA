// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int number)
{
    int result = 0;
    int result1 = 0;
    if (number >= 10)
    {
        while (number >= 1)
        {
            result = number % 10;
            result1 = result1 + result;
            number = number / 10;
        }
    }
    else 
    {
        if (number >= 0)
        {
            result1 = number;
        }
        else
        {
            Console.WriteLine($"Число должно быть положительным");
        }     
    }
    return result1;
}

int number1 = ReadNumber("Введите число: ");
int sum = SumNumber(number1);
Console.WriteLine(sum);