// Программа,которая найдет точку пересечения двух прямых,заданных уравнениями
// y=k1*x-b1; y=k2*x-b2; значения b1,k1,b2,k2 задаются пользователем

double k1 = ReadInt("Введите значение k1: ");
double b1 = ReadInt("Введите значение b1: ");
double k2 = ReadInt("Введите значение k2: ");
double b2 = ReadInt("Введите значение b2: ");
double x = (b2-b1) / (k1-k2);
double y = k2 * (b2-b1) / (k1-k2) + b2;

if (k1 == k2)
    Console.WriteLine("Прямые не пересекаются, они параллельные");
else 
Console.WriteLine($"Координаты точки пересечения: {x}; {y}");

int ReadInt(string message)
{
    Console.Write(message);
    int namber = Convert.ToInt32(Console.ReadLine());
    return namber;
}

