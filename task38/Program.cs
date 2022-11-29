// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементами массива.

double[] array = {12.2, 6.5, 10.3, 28.8, 30.5};
double max = array[0];
double min = array[0];
double dif = 0;
for (int i = 0;i < 5; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}
dif = max - min;
Console.WriteLine($"max: {max}; min: {min}; разница между ними: {dif}");
