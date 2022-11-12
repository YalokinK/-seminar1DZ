Console.WriteLine("Запишите целое число ");
int namberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Запишите второе целое число ");
int namberTwo = Convert.ToInt32(Console.ReadLine());

if (namberOne > namberTwo)
    Console.WriteLine("max = namberOne");
else
    Console.WriteLine("max = namberTwo");