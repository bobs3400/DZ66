using System;
using static System.Console;
Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine()!);
Write("Введите число N: ");
int n = int.Parse(ReadLine()!);

WriteLine();
WriteLine($"M = {m}; N = {n} -> {SumNumbers(m, n)}");

int SumNumbers(int m, int n)
{   
    if(n == m)
        return m;
    return (n + SumNumbers(m, n - 1));
}