// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Введите значение n: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение m: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A(M,N) = {Akerman(x, y)}");

int Akerman(int n, int m)
{
      if (n == 0)
        return m + 1;
    else
    if ((n != 0) && (m == 0))
        return Akerman(n - 1, 1);
    else
        return Akerman (n - 1, Akerman(n, m - 1));
}