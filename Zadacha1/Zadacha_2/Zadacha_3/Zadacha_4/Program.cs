// Напишите программу, которая принимает на вход число(N),а на выходе все четные числа от 1 до N  
Console.WriteLine("Введите целое число: ");
int namberN = Convert.ToInt32(Console.ReadLine());
int namberA = 2;
while (namberA <= namberN)
{
    Console.Write(namberA + " ");
    namberA +=2;
}
