// Программа,которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же
// указание, что такого элемента нет
int m = ReadInt("Введите колличество строк: ");
int n = ReadInt("Введите колличество столбцов: ");
int[,] matr = new int[m,n];
FillArrayRandomNambers(matr);
PrintArray(matr);
int namber = ReadInt("Введите позицию элемента в виде двузначного числа: ");
int i = namber / 10 - 1;
int j = namber % 10 - 1;
if (i< m || j< n )
    Console.WriteLine($"Этот элемент: {matr[i,j]} ");
else
    Console.WriteLine("Такого элемента в массиве нет");

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

