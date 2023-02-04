// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void FillArrayPosition(int[,] matr)
{
    Console.Write("Введите строку: ");
    int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите столбец: ");
    int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

    if (pos1 < 0 | pos1 > matr.GetLength(0) - 1 | pos2 < 0 | pos2 > matr.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует  ");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", matr[pos1, pos2]);
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FillArrayPosition(matrix);