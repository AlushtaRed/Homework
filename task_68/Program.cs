// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int AkerMan(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkerMan(m - 1, 1);
    return AkerMan(m - 1, AkerMan(m, n - 1));

}
Console.WriteLine(AkerMan(3, 3));
