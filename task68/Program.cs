// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int M = ReadInt("Введите целое положительное число: ");
int N = ReadInt("Введите второе целое положительное число: ");
Console.WriteLine(fAkkerman(M, N));

int fAkkerman (int m,int n)
{
    if (m == 0)
        return n +1;
    else if (m > 0 && n == 0)
        return fAkkerman(m-1, 1);
    else if (m > 0 && n > 0)
        return fAkkerman(m-1, fAkkerman(m,n-1));
    else return 0;
}

int ReadInt(string message)
{
    Console.Write(message);
    int namber = Convert.ToInt32(Console.ReadLine());
    return namber;
}

