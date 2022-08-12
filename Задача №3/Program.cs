//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7  ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 8)
{
    Console.WriteLine("Ошибка");
}
if (N <= 0)
{
    Console.WriteLine("Ошибка");
}

if (N >=0 && N <= 8 ){
    bool Del(int N)
    {
    return N== 6 || N== 7;
    }
    bool result = Del(N);

    Console.WriteLine(result ? "Да, это выходной" : "Нет, это не выходной");
}