using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab4
{
    class Lab4
    {
        static void Main(string[] arr)
        {
            Random ran = new Random();
            Stopwatch time = new Stopwatch();
            TimeSpan resulttime1; TimeSpan resulttime2;
            Console.WriteLine("Введите кол-во элементов");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] mas = new int[n];
            for(int i =0; i<n;i++)
            {
                mas[i] = ran.Next(0, 999999999);
            }

            Console.WriteLine("Чётные числа:");
            time.Restart();
            int[] vubor = mas.Where(s => (s % 2 == 0)).OrderBy(s => s).ToArray(); 
            time.Stop();                                                        
            resulttime1 = time.Elapsed;
            time.Restart();
            vubor = mas.AsParallel().Where(s => (s % 2 == 0)).OrderBy(s => s).ToArray();
            time.Stop();
            resulttime2 = time.Elapsed;
            int a = 10;
            if (vubor.Length < 10)
                a = vubor.Length;
            for (int i = 0; i < a; i++)
            {
                Console.Write(vubor[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write("Время рассчёта: ");
            Console.WriteLine(resulttime1);
            Console.Write("Время рассчёта паралельно: ");
            Console.WriteLine(resulttime2);
            Console.WriteLine();

            Console.WriteLine("Нечётные числа:");
            time.Restart();
            vubor = mas.Where(s => (s % 2 == 1)).OrderBy(s => s).ToArray();
            time.Stop();
            resulttime1 = time.Elapsed;
            time.Restart();
            vubor = mas.AsParallel().Where(s => (s % 2 == 1)).OrderBy(s => s).ToArray();
            time.Stop();
            resulttime2 = time.Elapsed;
            a = 10;
            if (vubor.Length < 10)
                a = vubor.Length;
            for (int i = 0; i < a; i++)
            {
                Console.Write(vubor[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write("Время рассчёта: ");
            Console.WriteLine(resulttime1);
            Console.Write("Время рассчёта паралельно: ");
            Console.WriteLine(resulttime2);
            Console.WriteLine();

            Console.WriteLine("Сумма первой и последней цифры равна 6:");
            time.Restart();
            vubor = mas.Select(s => Convert.ToString(s)).Where(s => Convert.ToInt32(Convert.ToString(s.First())) + Convert.ToInt32(Convert.ToString(s.Last())) == 6).Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToArray();
            time.Stop();
            resulttime1 = time.Elapsed;
            time.Restart();
            vubor = mas.AsParallel().Select(s => Convert.ToString(s)).Where(s => Convert.ToInt32(Convert.ToString(s.First())) + Convert.ToInt32(Convert.ToString(s.Last())) == 6).Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToArray();
            time.Stop();
            resulttime2 = time.Elapsed;
            a = 10;
            if (vubor.Length < 10)
                a = vubor.Length;
            for (int i = 0; i < a; i++)
            {
                Console.Write(vubor[i]);
                Console.Write(" ");
            }
            if (vubor.Length > 0)
                Console.WriteLine();
            else
                Console.WriteLine("Таких чисел нет");
            Console.Write("Время рассчёта: ");
            Console.WriteLine(resulttime1);
            Console.Write("Время рассчёта паралельно: ");
            Console.WriteLine(resulttime2);
            Console.WriteLine();

            Console.WriteLine("Числа, содержащие комбинацию цифр: 666");
            time.Restart();
            vubor = mas.Select(s => Convert.ToString(s)).Where(s => s.Contains("666")).Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToArray();
            time.Stop();
            resulttime1 = time.Elapsed;
            time.Restart();
            vubor = mas.AsParallel().Select(s => Convert.ToString(s)).Where(s => s.IndexOf("666") > -1).Select(s => Convert.ToInt32(s)).OrderBy(s => s).ToArray();
            time.Stop();
            resulttime2 = time.Elapsed;
            a = 10;
            if (vubor.Length < 10)
                a = vubor.Length;
            for (int i = 0; i < a; i++)
            {
                Console.Write(vubor[i]);
                Console.Write(" ");
            }
            if (vubor.Length > 0)
                Console.WriteLine();
            else
                Console.WriteLine("Таких чисел нет");
            Console.Write("Время рассчёта: ");
            Console.WriteLine(resulttime1);
            Console.Write("Время рассчёта паралельно: ");
            Console.WriteLine(resulttime2);
            Console.WriteLine();

            Console.ReadLine(); 
        }
    }
}
