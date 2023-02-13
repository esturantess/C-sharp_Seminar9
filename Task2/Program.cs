// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void NaturalNumbersOutput(int leftBorder, int rightBorder)
{
    if (leftBorder == rightBorder) Console.Write(rightBorder + " ");
    else
    {
        NaturalNumbersOutput(leftBorder, rightBorder - 1);
        Console.Write(rightBorder + " ");
    }

}

Random rand = new Random();
int M = rand.Next(1, 51);
int N = rand.Next(1, 51);
int leftBorder = M;
int rightBorder = N;
if (M < N)
{
    leftBorder = M;
    rightBorder = N;
    Console.WriteLine($"Промежуток чисел от {leftBorder} до {rightBorder}: ");
}
else if (M > N)
{
    leftBorder = N;
    rightBorder = M;
    Console.WriteLine($"Промежуток чисел от {leftBorder} до {rightBorder}: ");
}
else System.Console.WriteLine(M);

NaturalNumbersOutput(leftBorder, rightBorder);