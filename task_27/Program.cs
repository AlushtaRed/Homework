// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int Sum(int number)
{
if (number > 9)
{
int result = 0;
for (int temp = number; temp > 0; temp = temp/10)
{
    result = result + temp%10;
}
Console.WriteLine(result);
}
else Console.WriteLine(number);
return number;
}
Sum(number);