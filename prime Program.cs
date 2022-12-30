using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_Numper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j,start_num,end_num,flag=0;
            double count;
            Console.WriteLine("Enter Start Number");
            start_num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter End Number");
            end_num = int.Parse(Console.ReadLine());
            count = Math.Ceiling(Math.Sqrt(end_num));
            for(i=start_num;i<=end_num;i++)
            {
                for (j = 2; j <= count; j++) {

                    if (i != j && i % j == 0) {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0) {
                    Console.Write(i + "  ");
                }
                flag = 0;
            }
            Console.ReadKey();

        }
    }
}
