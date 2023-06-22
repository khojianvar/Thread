using System.Text;

namespace thread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string juft = "--- Juft son ---";
            string tub = "--- Tub son ---";

            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            string pathTub = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Tubson.txt";
            string pathJuft = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Juftson.txt";


            Thread thread1 = new Thread(() => CalculateTub(num, ref juft));
            Thread thread2 = new Thread(() => CalculateJuft(num, ref tub));
            thread1.Start();
            thread2.Start();

            if (File.Exists(pathJuft))
            {
                File.WriteAllText(pathJuft, juft);
            }
            else
            {
                File.CreateText(pathJuft).Close();
                File.WriteAllText(pathJuft, juft);
            }

            if (File.Exists(pathTub))
            {
                File.WriteAllText(pathTub, tub);
            }
            else
            {
                File.CreateText(pathTub).Close();
                File.WriteAllText(pathTub, tub);
            }
        }

        static void CalculateTub(int num, ref string str)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            for (int i = 1; i <= num; i++)
            {
                counter = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    Console.WriteLine($"Tub son: {i}");
                    Thread.Sleep(1000);
                    sb.Append($"Tub son: {i}\n");
                }
            }
            str += sb.ToString();
            Console.WriteLine("Processing [Tub son] is finished");
        }

        static void CalculateJuft(int num, ref string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Juft son: {i}");
                    Thread.Sleep(1000);
                    sb.Append($"Juft son: {i}\n");
                }
            }
            str += sb.ToString();
            Console.WriteLine("Processing [Juft son] is finished");
        }
    }
}