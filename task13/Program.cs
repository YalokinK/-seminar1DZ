//Программа выводит третью цифру заданного числа или сообщает, что этого числа нет

Console.WriteLine("Введите любое целое число: ");
int namber = Convert.ToInt32(Console.ReadLine());

while (namber > 999)
{
    namber = namber / 10;
} 
if (99 < namber)
    Console.WriteLine(namber % 10);
else
    Console.WriteLine("Третьей цифры нет");
