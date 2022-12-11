// Программа,которая заполняет спирально массив (например:4 на 4).

int size = ReadInt("Введите размерность квадратного массива: ");
int[,] nambers = new int[size,size];
int value = 1;
int i = 0;
int j = 0;
while (value <= nambers.Length)
{
    nambers[i,j] = value++;
    if (i <= j+1 && i+j < size - 1) j++;
    else if (i < j && i+j >= size - 1) i++;
    else if (i >= j && i+j > size - 1) j--;
    else i--;
}
Print2DArray(nambers); 

int ReadInt(string message)
{
    Console.Write(message);
    int namber = Convert.ToInt32(Console.ReadLine());
    return namber;
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
