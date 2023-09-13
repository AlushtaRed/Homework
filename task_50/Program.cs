// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, 
// с каждым новым элементом увеличивающимся на опрделенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, 
// m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) 
// и возвращает матрицу, удовлетворяющую этим условиям.
int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    int temp = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = temp;
            temp = matrix[i, j] + k;
        }
    }
    return matrix;
}

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.


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
// Метод FindNumberByPosition принимает на вход сгенрированную матрицу и числа x и y - позиции элемента в матрице.
//  Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: 
// значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, 
// что операция прошла успешно без ошибок.
int[] FindNumberByPosition(int[,] matrix, int x, int y)
{
    int[] result = new int[2];
    if (x < matrix.GetLength(0) && y < matrix.GetLength(0))
    {
        result[0] = matrix[x, y];
        result[1] = 0;
        return result;
            }

    else
    result = null;

        return result;
        

}
void PrintCheckIfError (int[] result, int x, int y)
{
    if(result == null)
{
    Console.WriteLine("There is no such index");
}
else 
Console.WriteLine($"The number in [{x}, {y}] is {result[0]}");

}
int x=8;
int y =2;
CreateIncreasingMatrix(3, 4, 6);
PrintArray(CreateIncreasingMatrix(3, 4, 6));
FindNumberByPosition(CreateIncreasingMatrix(3, 4, 6), x, y);
PrintCheckIfError(FindNumberByPosition(CreateIncreasingMatrix(3, 4, 6), x, y),x,y);