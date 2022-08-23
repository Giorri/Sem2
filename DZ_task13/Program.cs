// Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6 , 78 -> третьей цифры нет; 32679 -> 6
Console.WriteLine("Задайте число: ");
int numberA = int.Parse(Console.ReadLine());
int num = (numberA % 1000) / 100;
if (num == 0)
{
    Console.WriteLine("Третьей цифры нет");
} 
else
{
    Console.WriteLine($"Наша цифра: {num}");
}