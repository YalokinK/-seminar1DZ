// Программа,которая задает массив из N элементов и выводит их на экран.
// Вывод сделать отдельным методом.
   
Console.WriteLine("Введите любое положительное целое число(N): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
void PrintArray(int[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
PrintArray(array);
Console.WriteLine();


