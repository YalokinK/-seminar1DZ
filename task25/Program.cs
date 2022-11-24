// Напишите цикл, который принимает на вход два числа (А и В) и возводит
// число А в натуральную степень В:

int namberA = new Random().Next(1, 10);
int namberB = new Random().Next(1, 10);
int result = 1;
for (int count = 1; count <= namberB; count ++)
{
    result = result * namberA;
}
Console.WriteLine($"Число {namberA} в степени {namberB} равно " + result);
