// Напишите программу, которая принимает число на вход и выдаёт, является оно четным или нет
Console.WriteLine("Введите целое число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int result = namber % 2;

if (result != 0)
    Console.WriteLine(namber + " => нет");
else
    Console.WriteLine(namber + " => да");
