/*
void NaturalNums(int n)
{
    if(n >= 1)
    {
        Console.Write(n + " ");
        NaturalNums(n - 1);
    }
}


NaturalNums(10);
*/
//Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.
/*

void SumOfNatNums(int M, int N, int sum = 0)
{
    if (M == N + 1)
    {
        Console.WriteLine(sum);
    }
    else
    {
        SumOfNatNums(M + 1, N, sum + M);
    }
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
SumOfNatNums(a, b);

*/
//Задача 67: Напишите программу, которая будет
//принимать на вход число и возвращать сумму его цифр.

void SumOfNums(int n, int sum = 0)
{
    if (n == 0)
    {
        Console.WriteLine(sum);
    }
    else
    {
        SumOfNums(n / 10, sum + n % 10);
    }
}

int a = Convert.ToInt32(Console.ReadLine());
SumOfNums(a);