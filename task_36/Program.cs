// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = new int[4];
int length = array.Length;
int index = 0;
int sum = 0;
void FillPrintArray(int[] array)
{
    while (index < length)
    {
        array[index] = new Random().Next(0, 10);
        Console.Write(array[index] + " ");
        index++;
    }
}

FillPrintArray(array);
for (index = 0; index < length; index++)
{
    if (index % 2 == 0)
        sum = sum + array[index];
}
Console.WriteLine();
Console.WriteLine("Сумма нечетных элементов массива = " + sum);