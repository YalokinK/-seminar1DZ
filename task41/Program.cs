// Пользователь вводит М чисел.
// Посчитайте,сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите целые числа через запятую: ");
string nambersM = Console.ReadLine();
int[] nambers = nambersM.Split(',').Select(int.Parse).ToArray();
Console.WriteLine("\nМассив: {0}",string.Join(" ",nambers));
int count = 0;
for (int i=0; i < nambers.Length; i++)
{
    if (nambers[i] <= 0)
        continue;
    else
        count++;
}    
Console.WriteLine("Положительных чисел: " + count);

