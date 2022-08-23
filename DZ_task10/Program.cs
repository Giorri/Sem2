// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int num = new Random().Next(100,1000);
Console.WriteLine($"Наше число {num}");
int number2 = (num / 10) % 10;
Console.WriteLine($"Вторая цифра: {number2}");