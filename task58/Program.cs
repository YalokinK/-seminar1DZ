// Задайте две матрицы. Напишите программу,которая будет
// находить произведение двух матриц.

int rowsFirstMatrix = ReadInt("Введите колличество строк первой матрицы: ");
int columnsFirstMatrix = ReadInt("Введите колличество столбцов первой матрицы: ");
int rowsSecondMatrix = ReadInt("Введите колличество строк второй матрицы: ");
int columnsSecondMatrix = ReadInt("Введите колличество столбцов второй матрицы: ");
int[,] matrixFirst = new int[rowsFirstMatrix, columnsFirstMatrix];
int[,] matrixSecond = new int[rowsSecondMatrix, columnsSecondMatrix];
Fill2DArrayRandomNambers(matrixFirst);
Print2DArray(matrixFirst);
Console.WriteLine();
Fill2DArrayRandomNambers(matrixSecond);
Print2DArray(matrixSecond);
Console.WriteLine();
int[,] resultMatrix = new int[rowsFirstMatrix, columnsSecondMatrix];
for (int j=0; j<resultMatrix.GetLength(1); j++)
{
    for (int i=0; i<resultMatrix.GetLength(0); i++)
    {
        for (int y=0; y<matrixFirst.GetLength(1); y++)
        {
            resultMatrix[j,i] += matrixFirst[i,y] * matrixSecond[y,j]; 
        }
    }
}
Print2DArray(resultMatrix);

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