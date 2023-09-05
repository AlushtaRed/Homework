// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Сколько чисел будем вводить?");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];

void FillArray(int[] array)
{
    Console.WriteLine("Введите числа");
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    Console.WriteLine(String.Join("  ", array));

}

FillArray(array);
int count = 0;
int length = array.Length;
for (int index = 0; index < length; index++)
{
    if (array[index] > 0)
        count = count + 1;

}
Console.WriteLine($"Количество положительных чисел - {count}");

// ParseNumber("Введите число");
