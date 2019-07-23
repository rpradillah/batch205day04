using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay04
{
    class Program
    {
        public static int count(int x)
        {
            return x + 2;
        }
        static void Main(string[] args)
        {
            int number = 10;
            int number2 = count(number);
            bool status = true;
            //penulisan dengan parameter index
            Console.WriteLine("Welcome Back ! {0} {1}", number,status);
            //penulisan dengan ++ 
            Console.WriteLine("Welcome Back ! " + number + " " + status);
            Console.WriteLine(number2);
        }
    }
}
