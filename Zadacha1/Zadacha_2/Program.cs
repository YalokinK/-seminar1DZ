// Программа, которая на вход принимает три числа и выдает max из этих чисел
Console.WriteLine("Введите целое число: ");
int namberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число: ");
int namberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье целое число: ");
int namberC = Convert.ToInt32(Console.ReadLine());

if (namberA > namberB)
    if (namberA > namberC)
        Console.WriteLine("max=>" + namberA);
    else
        Console.WriteLine("max=>" + namberC);
else
if (namberB > namberC)
    Console.WriteLine("max=>" + namberB);
else 
    Console.WriteLine("max=>" + namberC);




