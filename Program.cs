// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int M, N;
        Console.Write("Введите значение M: ");
        M = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        N = Convert.ToInt32(Console.ReadLine());

        if (M < N)
        {
            PrintNaturalNumbers(M, N);
        }
        else
        {
            Console.WriteLine("Значение M не может быть больше или равно значению N.");
        }
    }

    static void PrintNaturalNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.WriteLine(M);
            PrintNaturalNumbers(M + 1, N);
        }
    }
}
