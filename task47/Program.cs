// Задайте двумерный массив размером m x n,заполненный
// случайными вещественными числами

int m = ReadInt("Введите колличество строк m: ");
int n = ReadInt("Введите колличество столбцов n:");
double [,] matr = new double[m, n];
FillArrayRandomNambers(matr);
PrintArray(matr);

void FillArrayRandomNambers(double[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new  Random(  ).NextDouble();
            matrix[i,j] = Math.Round(matrix[i,j] * 10, 2);
        }
    }
}

void PrintArray(double[,] matrix)
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
