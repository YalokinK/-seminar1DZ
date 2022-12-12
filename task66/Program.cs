// Задайте значения M и N. Напишите программу,которая найдет
// сумму натуральных элементов в промежутке от M до N.

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
if (M > N)
{ 
    int temp = M;
    M = N;
    N = temp;
}
int SumRec (int m, int n)
{
    if (m == n) 
    return n;
    else
    {
        return n + SumRec(m, n-1);
    }
}
Console.WriteLine(SumRec(M, N));


int ReadInt(string message)
{
    Console.Write(message);
    int namber = Convert.ToInt32(Console.ReadLine());
    return namber;
}
