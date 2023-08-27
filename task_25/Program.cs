// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень");
// int degree = Convert.ToInt32(Console.ReadLine());

int ParceNumber(string text)
{
    System.Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int ParceDegree(string text)
{
    System.Console.WriteLine(text);
    int degree = Convert.ToInt32(Console.ReadLine());
    return degree;
}

int Degree(int number, int degree)
{
int result = number;   
for (int count = 2; count <=degree; count++)
{
result = result*number;
}
return result;
}
//string text = "Введите число";
int number = ParceNumber("Введите число");
//string text1 = "Введите степень";
int degree = ParceDegree("Введите степень");
int result = Degree(number, degree);
Console.WriteLine(result);