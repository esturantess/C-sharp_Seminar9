// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

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

int Exponentiation(int number, int degree)
{
    if (degree == 0)
    {
        return 1;
    }
    else
    {
        return number * Exponentiation(number, degree - 1);
    }
}

int firstNumber = InputNumber("Введите число A: ");
int secondNumber = InputNumber("Введите целую степень B: ");
Console.WriteLine($"Число {firstNumber} в степени {secondNumber} = {Exponentiation(firstNumber, secondNumber)}.");

// Решение с семинара

// int FuncRecursion(int num, int i)
// {
//     if (i > 0)
//     {
//         return num * FuncRecursion(num, i - 1);
//     }
//     return 1;
// }

// Console.WriteLine(FuncRecursion (2,5));