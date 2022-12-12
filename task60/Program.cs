// Сформируйте трехмерный массив из неповторяющихся двухзначных
// чисел. Напишите программу,которая будет выводить массив,
// добавляя индексы каждого элемента.

int row = ReadInt("Введите колличество строк: ");
int col = ReadInt("Введите колличество столбцов: ");
int dep = ReadInt("Введите колличество страниц: ");
int[,,] matrixGreat = new int [row, col, dep];
int value = 10;
for (int i=0; i<matrixGreat.GetLength(0); i++)
{
    for (int j=0; j<matrixGreat.GetLength(1); j++)
    {
         for (int y=0; y<matrixGreat.GetLength(2); y++)
        {
            matrixGreat[i,j,y] = value++;
        }
    }
//    return matrixGreat;
}
Print3DArray(matrixGreat);

void Print3DArray(int[,,] matrix)
{
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            for (int y=0; y<matrix.GetLength(2); y++)
            {
                Console.Write($"{matrix[i,j,y]}({i},{j},{y}) ");
            }
            Console.WriteLine();
        }
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    int namber = Convert.ToInt32(Console.ReadLine());
    return namber;
}    
