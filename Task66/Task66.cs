// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear(); 
Console.WriteLine("Введите первое число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число"); 
int b = Convert.ToInt32(Console.ReadLine()); 


Console.WriteLine(Sum(a, b));
int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}