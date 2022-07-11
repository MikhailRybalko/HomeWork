/*
Задача 29:
Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
1,2,5,7,19 -> [1,2,5,7,19]
6,1,33 -> [6,1,33]
*/


int [] GetArray(int demension)
{
    int[] arr = new int[demension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =  randomizer.Next(0, 10);
    }
    return arr;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void PrintArrayNeg(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
        Console.Write($"{array[i]} ");
    }
}


Console.WriteLine("Введите ряд чисел через запятую: ");
int demension = int.Parse(Console.ReadLine());

int [] arr = GetArray(demension);
PrintArray(array);
Console.WriteLine();
PrintArrayNeg(array);





