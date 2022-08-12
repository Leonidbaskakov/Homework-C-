// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число ");
int number1 = Convert.ToInt32(Console.ReadLine());


int num1 = number1 / 10;
int num2= num1 % 10;


Console.WriteLine($"Вторая цифра числа {number1} => {num2}");

