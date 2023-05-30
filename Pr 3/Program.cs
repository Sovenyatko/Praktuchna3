namespace Pr_3;
using System;

class Program
{
    static void Main(string[] args)
    {
        double sum = 0.0;
        double term = 1.0;

        // обчислюємо суму ряду з точнiстю до 0,000001
        for (int i = 1; term > 0.000001; i++)
        {
            term = 1.0 / (i * i);
            sum += term;
        }

        Console.WriteLine("Сума ряду з точнiстю до 0,000001: {0}", sum);

        // обчислюємо суму перших 10 членiв ряду
        sum = 0.0;
        for (int i = 1; i <= 10; i++)
        {
            term = 1.0 / (i * i);
            sum += term;
        }

        Console.WriteLine("Сума перших 10 членiв ряду: {0}", sum);
    }
}
