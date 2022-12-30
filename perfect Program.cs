using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Start Number ,Please :) ");
            int start_Num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The End Number ,Please :) ");
            int end_Num = int.Parse(Console.ReadLine());
            for (int i = start_Num; i <= end_Num; i++)
            {
                if (PerfectNumber(i))
                { Console.Write(i + "  "); }
            }

            Console.ReadKey();
        }
        public static bool PerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == number)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }
}

