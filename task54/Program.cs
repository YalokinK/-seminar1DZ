// Задайте двумерный массив. Напишите программу,которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

int m = ReadInt("Введите число строк: ");
int n = ReadInt("Введите число столбцов: ");
int[,] matr = new int[m,n];
Fill2DArrayRandomNambers(matr);
Print2DArray(matr);
int minPosition = 0;
for (int i=0; i<matr.GetLength(0); i++)
{
    for (int j=0; j<matr.GetLength(1); j++)
    {
    minPosition = j;
        for (int y = 0; y<matr.GetLength(1)-1; y++)
        {
            if (matr[i,minPosition] > matr[i,y]) 
            {
                int temp = matr[i,y];
                matr[i,y] = matr[i,minPosition];
                matr[i,minPosition] = temp;
            }
        }
    }
}
Console.WriteLine();
Print2DArray(matr);

void Fill2DArrayRandomNambers(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new  Random().Next(0,10);
        }
    }
}

void Print2DArray(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

}

int ReadInt(string message)
{
    Console.Write(message);
    int namber = Convert.ToInt32(Console.ReadLine());
    return namber;
}
