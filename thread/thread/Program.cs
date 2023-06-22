using System.Threading;

namespace thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            int m = 1;
            while (num > 0)
            {
                Thread thread1 = new Thread(() => Calculate(num));
                thread1.Start();
                thread1.Name = $"{m}";
                m++;
                Console.Write("Enter the number: ");
                num = int.Parse(Console.ReadLine());
            }
        }

        static void Calculate(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.Name}: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}