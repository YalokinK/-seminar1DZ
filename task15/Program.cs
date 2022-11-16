// Принимает на вход число,обозначающее день недели,и проверяет,являеься ли этот день выходным 
Console.WriteLine("Введите число,соответсвующее дню недели: ");
int namber = Convert.ToInt32(Console.ReadLine());

if (namber == 1 || namber == 2 || namber == 3 || namber == 4 || namber == 5)
    Console.WriteLine("нет");

else if (namber == 6 || namber == 7)
    Console.WriteLine("Да");
else
Console.WriteLine("Такого дня недели нет");

