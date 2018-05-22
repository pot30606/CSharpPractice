using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02_JosephusProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("猴子選大王! 請輸入有幾隻猴子");
            int Total = int.Parse(Console.ReadLine());
            /*
            int nowcount = 0;
            int[] Monkey = new int[10];
            int i = 0;
            while (Monkey.Length == 1)
            {
                if (Monkey[i] != 0)
                {
                    
                }
            }
            */


            
            int num = 0;
            int kill = 3;
            for(int i = 2; i <= Total; i++)
            {
                num = (num + kill) % i;
            }
            num++;

            Console.WriteLine(num);
            






            /*
            LinkedListNode<int> node = new LinkedListNode<int>(1);
            LinkedList<int> link = new LinkedList<int>();
            for (int i = 2; i <= Total; i++)
            {
                link.AddLast(i);
            }
            var next = link.First.Next;

            Console.WriteLine(link.First.Value);
            Console.WriteLine(link.First.Next.Value);
            Console.WriteLine(link.First.Next.Next.Value);
            */




            Console.ReadLine();
        }
    }
}
