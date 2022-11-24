// Программа приримает на вход число и выдает сумму цифр в числе:

Console.WriteLine("Введите любое целое число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (namber > 0)
{
    sum = sum + namber % 10;
    namber = namber / 10;
}
Console.WriteLine($"Сумма цифр: {sum}");
