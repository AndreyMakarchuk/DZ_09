// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите начальное число M: ");
int numberM = int.Parse(Console.ReadLine()!);

Console.Write("Введите начальное число N: ");
int numberN = int.Parse(Console.ReadLine()!);

int AckFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numberM != 0 && numN == 0) return AckFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckFunction(numM - 1, AckFunction(numM, numN - 1));
return AckFunction(numM, numN);
}

Console.WriteLine($"-> A ({numberM}, {numberN}) = {AckFunction(numberM, numberN)}");