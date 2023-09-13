﻿// Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }

}
void FindMin(int[,] array)
{
    int minNumber = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minNumber)
            {
                minNumber = array[i, j];
                row = i;
                column = j;
            }


        }

    }
Console.WriteLine($"минимальное значение {minNumber}, ряд - {row}, столбец - {column}");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != row && j != column)
            {
                Console.Write(array[i, j] + " ");

            }

        }
        Console.WriteLine();
    }
}
int[,] array = new int[4, 5];
FillArray(array);
FindMin(array);

