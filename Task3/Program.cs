// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено некорректное число, попробуйте ещё раз!");
    }
    return number;
}

int SumOfTheDigitsInNumber(int number)
{
    if (number == 0)
    {
        return 0;
    }
    else
    {
        return number % 10 + SumOfTheDigitsInNumber(number / 10);
    }
}

int number = InputNumber("Введите число: ");
Console.WriteLine($"Сумма цифр числа {number}: {SumOfTheDigitsInNumber(number)}.");

// Решение с семинара

// int Sum(int number)
// {
//     if (number == 0)
//     {
//         return 0;
//     }
//     return number % 10 + Sum(number / 10);
// }

// int number = 453;
// System.Console.WriteLine(Sum(number));
