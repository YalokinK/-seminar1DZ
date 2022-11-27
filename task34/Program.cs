// Задайте массив,заполненный случайными положительными трехзначными числами.
// Напишите программу,которая покажет колличество четных чисел в массиве.

Console.WriteLine("Какой будет размер массива? Введите цифру: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
void FillArrayRandomNambers(int[] array, int min, int max)
{
    for (int i=0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
FillArrayRandomNambers(array, 100, 1000);
void WriteArray(int[] array)
{
    for (int i=0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}
WriteArray(array);
for (int i=0; i < size; i++)
{
    if (array[i] % 2 == 0)
    {
        
         count++;
    }
    else
    {
      continue;
    }  
    
}
Console.WriteLine();
Console.WriteLine("Колличество четных чисел в массиве: " + count);
