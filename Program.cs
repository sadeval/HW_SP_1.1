using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{

    [DllImport("kernel32.dll")]
    public static extern bool Beep(int frequency, int duration);

    [DllImport("user32.dll")]
    public static extern bool MessageBeep(uint uType);

    static void Main()
    {
        Console.WriteLine("Генерация звуковых сигналов...");

        for (int i = 0; i < 3; i++)
        {
            Beep(800, 500); // Частота 800 Гц, длительность 500 мс
            Thread.Sleep(1000); // Пауза 1 секунда
        }

        MessageBeep(0xFFFFFFFF); // Стандартный звуковой сигнал
        Thread.Sleep(1000); // Пауза 1 секунда

        for (int i = 0; i < 3; i++)
        {
            Beep(1000, 300); // Частота 1000 Гц, длительность 300 мс
            Thread.Sleep(700); // Пауза 0.7 секунды
        }

        Console.WriteLine("Звуковые сигналы завершены.");
    }
}
