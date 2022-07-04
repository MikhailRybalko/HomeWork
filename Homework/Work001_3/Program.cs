/*
Задача 15:
Напишите программу, которая принимает на вход цифру, обозначенную день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите день недели");
string day = Console.ReadLine();

if (day == "1")
{
    Console.WriteLine("Понедельник");
    Console.WriteLine("Рабочий день");
}
else if (day == "2")

    Console.WriteLine("Вторник");

    else if (day == "3")
    Console.WriteLine("Среда");
    
    else if (day == "4")
    Console.WriteLine("Четверг");

    else if (day == "5")
    Console.WriteLine("Пятница");

    else if (day == "6")
    Console.WriteLine("Суббота");

    else if (day == "7")
    Console.WriteLine("Воскресенье");

if (day == "6")
Console.WriteLine("Выходной день!");
else if (day =="7")
Console.WriteLine("Выходной день!");

if (day == "2")
Console.WriteLine("Рабочий день!");

if (day == "3")
Console.WriteLine("Рабочий день!");

if (day == "4")
Console.WriteLine("Рабочий день!");

if (day == "5")
Console.WriteLine("Рабочий день!");
