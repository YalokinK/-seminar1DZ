// Программа принимает на вход число N и выдает таблицу кубов от 1 до N:
Console.WriteLine("Введите  целое число: ");

int namber = Convert.ToInt32(Console.ReadLine());
int namberA = 0;

while (namberA < namber)
{
    namberA++;
Console.WriteLine(namberA * namberA * namberA + "");
}