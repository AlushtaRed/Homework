// // Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на опрделенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, 
// m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) 
// и возвращает матрицу, удовлетворяющую этим условиям.


int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int temp = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = temp;
            temp = matrix[i, j] + k;
        }


    }
    return matrix;

}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  " + "\t");
        }
        Console.WriteLine();

    }
}
// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] 
// и возвращает одномерный массив типа double. Этот метод вычисляет среднее 
// значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.


double[] FindAverageInColumns(int[,] matrix)
{
    double[] list = new double[matrix.GetLength(1)];
    
    
    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        double sum = 0;
        for (int m = 0; m < matrix.GetLength(0); m++)
        {
            int j =k;
            int i = m;
            sum = sum + matrix[i,j];
        
        }
        list[k] = Math.Round(sum/(double)matrix.GetLength(0), 2);

        

    }
    return list;


}
void PrintListAvr(double[] list)
{
Console.WriteLine("The averages in columns are:");
    for (int i = 0; i < list.Length  ; i++)
    {
        Console.Write(String.Format("{0:0.00}",list[i]) + "   ");
    }

}





CreateIncreasingMatrix(4, 5, 3);
PrintArray(CreateIncreasingMatrix(4, 5, 3));
FindAverageInColumns(CreateIncreasingMatrix(4, 5, 3));
PrintListAvr(FindAverageInColumns(CreateIncreasingMatrix(4, 5, 3)));
