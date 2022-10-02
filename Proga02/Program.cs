// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите начальное число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите начальное число N: ");
int n = int.Parse(Console.ReadLine()!);


void GapNumberSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"-> {sum}");
        return;
    }
    sum = sum + (m++);
    GapNumberSum(m, n, sum);
}

GapNumberSum(m, n, 0);