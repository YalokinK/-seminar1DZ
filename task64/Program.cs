// Задайте значение N. Напишите программу,которая выведет все
// натуральные числа от от N до 1. Выполнить с помощью рекурсии.

int namber = ReadInt("Введите число N: ");
Console.WriteLine(NaturalNamber(namber));

int NaturalNamber(int n)
{
    if (n == 1) return 1;
    else
    {
         Console.Write(n + ", ");
        NaturalNamber(n-1);
//        return 1;
    }
    return 1;
}

int ReadInt(string message)
{
    Console.Write(message);
    int namber = Convert.ToInt32(Console.ReadLine());
    return namber;
}

