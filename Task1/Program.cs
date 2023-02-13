// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void NaturalNumbersOutput(int boundary)
{
    if (boundary == 1) Console.Write(boundary + " ");
    else
    {
        NaturalNumbersOutput(boundary - 1);
        Console.Write(boundary + " ");
    }
}

Random rand = new Random();
int intervalBoundary = rand.Next(1, 101);
NaturalNumbersOutput(intervalBoundary);

// Решение с семинара

// void FunctionN(int numb)
// {
//     if (numb > 1)
//     {
//         FunctionN(numb - 1);
//     }
//     Console.WriteLine(numb);
// }

// FunctionN(3);