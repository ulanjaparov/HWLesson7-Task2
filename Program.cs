// Урок 7. Рекурсия
// Задание сдавать в виде ссылки на репозиторий GitHub.

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения m и n:");

        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Результат функции Аккермана для ({m}, {n}) равен: {Ackermann(m, n)}");
    }
}

