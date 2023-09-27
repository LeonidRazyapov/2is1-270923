using System;

class Program
{
    static void Main()
    {
        // Запрос данных у пользователя
        Console.WriteLine("Введите часы:");
        int N = int.Parse(Console.ReadLine()); // Часы

        Console.WriteLine("Введите минуты:");
        int M = int.Parse(Console.ReadLine()); // Минуты

        Console.WriteLine("Введите время доставки в минутах:");
        int T = int.Parse(Console.ReadLine()); // Время доставки в минутах

        // Вычисление общего времени в минутах
        int totalMinutes = N * 60 + M + T;

        // Вычисление времени на электронных часах
        int hoursOnClock = (totalMinutes / 60) % 24;
        int minutesOnClock = totalMinutes % 60;

        // Вывод времени на электронных часах
        Console.WriteLine($"Время на электронных часах: {hoursOnClock:D2}:{minutesOnClock:D2}");
    }
}
