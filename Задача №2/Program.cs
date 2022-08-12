// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1>999 && number1<9999 )
{
int res= (number1 % 100) /10;
Console.WriteLine($"{res}");
}
else
if (number1<1000 && number1>99 )
{
    int res= (number1 % 10) %10;
Console.WriteLine($"{res}");
}
else
if (number1<=99)
{
    Console.WriteLine("Третей цифры нет");
}
else 
Console.WriteLine("Число слишком длинное");
