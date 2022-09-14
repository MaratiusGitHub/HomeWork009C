// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите значение M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;

Console.WriteLine($"Cумма натуральных элементов в промежутке от M до N = {result(numberM, numberN, sum)}");

int result(int start, int end, int sum)
{
    sum += start;
    if (start == end) return sum;
    return (result(start + 1, end, sum));
}