// Программа принимает на вход 5-ти значное число и проверяет, является ли оно полиндроном:

Console.WriteLine("Введите любое пятизначное число: ");
int namber = Convert.ToInt32(Console.ReadLine());

if (namber % 10  == namber / 10000 && namber /10 % 10 == namber / 1000 % 10)
Console.WriteLine("Да");
else
Console.WriteLine("Нет");
