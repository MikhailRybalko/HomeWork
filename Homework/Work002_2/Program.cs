/*
Задача 21
Наришите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
в 3D пространстве.
A(3,6,8); B(2,1,-7) -> 15.84
A(7,-5,0); B(1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    int result =0;
    string errorMessage = "Вы ввели не число. Введите корректное число";

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
            break;
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
    }

    return result;

}

int x = GetNumber("Введите координаты x 1 точка");
int y = GetNumber("Введите координаты x 1 точка");
int z = GetNumber("Введите координаты x 2 точка");
int x1 = GetNumber("Введите координаты x 2 точка");
int y1 = GetNumber("Введите координаты x 3 точка");
int z1 = GetNumber("Введите координаты x 3 точка");

double length = Math.Sqrt((x -x1) * (x - x1) + (y-y1) * (y -y1) + (z - z1) * (z-z1));
Console.WriteLine($"Расстояние между точками равняется {length}");