// Задайте прямоугольный двумерный массив.
// Напишите программу,которая будет находить строку с наименьшей
// суммой элементов.

int m = ReadInt("Введите цифру,которая будет размером и для строк и для столбцов: ");
int[,] matr = new int[m,m];
Fill2DArrayRandomNambers(matr);
Print2DArray(matr);

int[] sum = new int[m];
int min = 0;
int index  = 1;
for (int i=0; i<matr.GetLength(0); i++)
{
    for (int j=0; j<matr.GetLength(1); j++)
    {
        sum[i] += matr[i,j];       
    }
}
Console.WriteLine();
WriteArray(sum);
for (int i = 0; i<sum.Length; i++)
{
    min = sum[0];
    if (sum[i] < min)
    {
        min = sum[i];
        index++;
    }
    else
        continue;
        index++;
}
Console.WriteLine($"Наименьшая сумма: {min} в строке {index}");


void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


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
