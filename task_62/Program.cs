// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] array = new int[4, 4];
int temp = 1;
for (int i = 0; i < 1; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = temp;
        temp = array[i, j] + 1;
    }

}
for (int i = 1; i < 3; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == 3)

        {
            array[i, j] = temp;
            temp = array[i, j] + 1;

        }

    }
}
for (int i = 3; i < array.GetLength(0); i++)
{
    for (int j = 3; j > 0; j--)
    {
        array[i, j] = temp;
        temp = array[i, j] + 1;

    }

};
for (int i = 3; i > 0; i--)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
    if (j == 0)
    {
        array[i, j] = temp;
        temp = array[i, j] + 1;
    }
    }
};
for (int i = 1; i < 2; i++)
{
    for (int j = 1; j < array.GetLength(1)-1; j++)
    {
        array[i, j] = temp;
        temp = array[i, j] + 1;
    }

};
for (int i = 2; i < array.GetLength(0)-1; i++)
{
    for (int j = 2; j > 0; j--)
    {
        array[i, j] = temp;
        temp = array[i, j] + 1;

    }

};
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "  " + "\t");
    }
    Console.WriteLine();
    
}





