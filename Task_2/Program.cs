// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Summa(int number)
{
    int count = 0;
    Console.Write($"Сумма цифр числа {number} = ");
    while (number > 0)
    {
        count += number % 10;
        number /= 10;
    }
    return count;    
}

Console.WriteLine(Summa(78));
Console.WriteLine(Summa(456));
Console.WriteLine(Summa(12369));
