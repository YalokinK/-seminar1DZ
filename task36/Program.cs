// Задайте одномерный массив,заполненный случайными числами.
// Найдите сумму элементов,стоящих на нечетных позициях.

Console.WriteLine("Какой будет размер массива? Введите цифру: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
void FillArrayRandomNambers(int[] array)
{
    for (int i=0; i<size; i++)
    array[i] = new Random().Next(-9, 10);
}

void PrintArray(int[] array)
{
    for (int i=0; i<size; i++)
    {
        Console.Write(array[i] + " ");
    }
}
FillArrayRandomNambers(array);
PrintArray(array);
for (int j=1; j<size; j +=2)
{
    sum = sum + array[j];
}
Console.WriteLine();
Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);
