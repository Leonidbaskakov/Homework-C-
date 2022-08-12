// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
Console.Write("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool Del(int number1)
    {
    return number1>99;
    }
    bool result = Del(number1);

Console.WriteLine(result ? number1.ToString()[2] : "Третей цифры нет");