using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();
            ReverseMessage();
            Console.ReadLine();
        }

      static  void  PrintMessage()
        {
            for(int i=1; i<=100; i++)
            {
                int num=i;
                if (num%3==0&&num%5==0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if(num % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }
        }

        static void ReverseMessage()
        {
            Console.WriteLine("enter some word:");
            string msg= Console.ReadLine();
            string revMsg = "";
            for (int i= msg.Length-1; i>=0;i--)
            {
                revMsg += msg[i];
            }
            Console.WriteLine(revMsg);
        }
    }
}
