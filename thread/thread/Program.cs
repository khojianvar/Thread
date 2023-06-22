using System.Threading;

namespace thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            Thread thread1 = new Thread(() => CalculateTub(num));
            Thread thread2 = new Thread(() => CalculateJuft(num));
            thread1.Start();
            thread2.Start();
        }

        static void CalculateTub(int num)
        {
            int counter = 0;
            for (int i = 1; i <= num; i++)
            {
                counter = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        counter++;
                    }
                }
                if(counter == 2)
                {
                    Console.WriteLine($"Tub son: {i}");
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Processing [Tub son] is finished");
        }

        static void CalculateJuft(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"Juft son: {i}");
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Processing [Juft son] is finished");
        }
    }
}