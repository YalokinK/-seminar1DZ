// Программа принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int randomNamber =  new Random().Next(100, 1000);

Console.WriteLine(randomNamber);

int dubleDigit = randomNamber / 10;
int lastDigit = dubleDigit % 10;

Console.WriteLine("Вторая цифра " + lastDigit);

