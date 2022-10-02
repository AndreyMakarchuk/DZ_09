// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

string Numbers(int a, int b)
{
    if (a == b) return a.ToString();
    return a + ", " + Numbers(a + 1, b);
}
Console.Write($"-> {Numbers(m, n)}");