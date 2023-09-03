// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = new int[5];
int length = array.Length;
int index = 0;
int count = 0;
void FillPrintArray(int[]array)
{
while (index<length)
    {
        array[index] = new Random().Next(100,999);
        Console.Write(array[index]+ " ");
        index++;
    }
}

FillPrintArray(array);
foreach (int number in array)
{ 
    
    if (number%2 == 0)
    {
        count = count + 1;
    }
    
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел массива - " + count);