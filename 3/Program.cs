// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9


Console.WriteLine("Введите первое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int M = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    if ((n > 0) && (m == 0))
        return AkkermanFunction(n - 1, 1);
    else
        return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}

Console.WriteLine($"Функция Аккермана от чисел {N} и {M} равна {AkkermanFunction(N, M)}.");