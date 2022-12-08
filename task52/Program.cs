// Задайте двумерный массив из целых чисел.Найдите среднее
// арифметическое элементов в каждом столбце.

int m = ReadInt("Введите колличество строк: ");
int n = ReadInt("Введите колличество столбцов: ");
int[,] matr = new int[m,n];
FillArrayRandomNambers(matr);
PrintArray(matr);
double sum = 0;
for (int j=0; j<matr.GetLength(1); j++ )
{
    for (int i=0; i<matr.GetLength(0); i++)
    {
        sum += matr[i,j];
    }
    Console.WriteLine(Math.Round(sum / matr.GetLength(0), 1));
    sum = 0;
}

void FillArrayRandomNambers(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new  Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] matrix)
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
