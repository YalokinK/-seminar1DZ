// Программа принимает на вход координаты двух точек и определяет расстояние между ними в 3D 
// прострастве

int aX = ReadInt("Введите координату X точки A: ");
int aY = ReadInt("Введите координату Y точки A: ");
int aZ = ReadInt("Введите координату Z точки A: ");
int bX = ReadInt("Введите координату X точки B: ");
int bY = ReadInt("Введите координату Y точки B: ");
int bZ = ReadInt("Введите координату Z точки B: ");

int sqrX = (aX - bX) * (aX - bX);
int sqrY = (aY - bY) * (aY - bY);
int sqrZ = (aZ - bZ) * (aZ - bZ);
double distanse = Math.Sqrt(sqrX + sqrY + sqrZ);
Console.WriteLine(distanse); 

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

