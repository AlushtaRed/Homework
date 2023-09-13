// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    double[,] matrix = new double[m, n];
    // void Fillarray(double[,] matrix)
    // {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(minLimitRandom, maxLimitRandom);
              
            }
            
        }

    // }
    // Fillarray(matrix);
    return matrix;

}
int m = 3;
int n = 4;
int minLimitRandom = -10;
int maxLimitRandom = 10;
CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
PrintArray(CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom));

// PrintArray(CreateRandomMatrix( m,  n,  minLimitRandom,  maxLimitRandom));


