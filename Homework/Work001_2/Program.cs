/*
Задача 13:
Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 - третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите трехзначное число и больше");
int number = int.Parse(Console.ReadLine());

if(number > 99 && number < 1000)
{
    Console.WriteLine($"Третья цифра {number % 10}");
}
else if(number > 10000 && number < 100000)
{
    Console.WriteLine($"Третья цифра {number /100%10}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
