using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_23
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите число n:");
                int n = Convert.ToInt32(Console.ReadLine());
                FactorialAsync(n);
                Console.ReadKey();
            }
            static void Factorial(int num)
            {
                int result = 1;
                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }
                Console.WriteLine($"Факториал числа {num} равен {result}");
            }
            static async void FactorialAsync(int num)
            {
                await Task.Run(() => Factorial(num));
            }
        }
    }
}
