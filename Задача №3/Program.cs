﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7  ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 8)
{
    Console.WriteLine("Ошибка");
}
else
if (N <= 0)
{
    Console.WriteLine("Ошибка");
}

if (N > 0 && N < 8)
{
    if (N == 1)
    {
        Console.WriteLine($"{N} -Понедельник");
    }
    else

    if (N == 2)
    {
        Console.WriteLine($"{N} -Вторник");
    }
    else

    if (N == 3)
    {
        Console.WriteLine($"{N} -Среда");
    }
    else

    if (N == 4)
    {
        Console.WriteLine($"{N} -Четверг");
    }
    else

    if (N == 5)
    {
        Console.WriteLine($"{N} -Пятница");
    }
    else

    if (N == 6)
    {
        Console.WriteLine($"{N} -Суббота");
    }
    else

    if (N == 7)
    {
        Console.WriteLine($"{N} -Воскресенье");
    }
    
    bool Del(int N)
    {
        return N == 6 || N == 7;
    }
    bool result = Del(N);

    Console.WriteLine(result ? "Да, это выходной" : "Нет, это не выходной");
}