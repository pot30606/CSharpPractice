using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork01_FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int[] array = new int[999];
            array[0] = 1;
            array[1] = 1;
            for (int i=1; i < 1836311903;)
            {
                Console.WriteLine(i);
                if (n >= 2)
                {
                    i = array[n - 2] + array[n - 1];
                    array[n] = i;
                    n++;
                }
                if (i <= 0)
                {
                    break;
                }
            }
            

            //遞迴
            /*
            int n = 1836311903;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(caculate(i));
            } 
            caculate(n);
            */


            Console.ReadLine();
        }

        private static int caculate(int n)
        {
            if(n==0 || n == 1)
            {
                return 1;
            }
            else
            {
                return caculate(n - 1) + caculate(n - 2);
            }

        }
    }
}
