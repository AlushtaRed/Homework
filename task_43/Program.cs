// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите значения для прямых через пробел");
string[]numbers = Console.ReadLine().Split(" ");
string[]meanings = {"b1", "k1", "b2", "k2"};

for (int i = 0; i < meanings.Length; i++)
Console.WriteLine(String.Join(" ", meanings[i] + " - " + numbers[i] + ", "));

double[] a = new double [meanings.Length];

for (int i = 0; i < numbers.Length; i++)
{
    a[i] = Convert.ToDouble(numbers[i]);
}
double x = -(a[0]/a[2]);
double y = a[3]*x + a[2];
Console.WriteLine(String.Join(" ", a));
Console.WriteLine($"Точкаа пересечения двух прямых: [{x}, {y}]");