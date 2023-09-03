// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double [] array = new double[5];

void FillArray(double[]array)
{
int length = array.Length;
int index = 0;

while (index<length)
{ array[index] = Math.Round(new Random().NextDouble(),2) + new Random().Next(1,100);
index++;
}
Console.WriteLine(String.Join("  ",array));
}
FillArray(array);

double maxindex = array[0];
double minindex = array[0];
int length = array.Length;
for (int i = 0; i < length; i++)
{
    if(array[i] > maxindex)
{
    maxindex = array[i];
}
    else minindex = array[i];
}
double result = maxindex - minindex;




Console.WriteLine($"Разница между max и min элементами массива = {maxindex} - {minindex} = {Math.Round(result,2)}");
