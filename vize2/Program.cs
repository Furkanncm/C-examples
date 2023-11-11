using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize2
{
    internal class Program
    {
        

        delegate void nevada(int number);

       static void square (int number)
        {
            Console.WriteLine(4*number^2+5*number+10);
        }
       static void cube (int number)
        {
            Console.WriteLine(number^3);
        }
       static void circle(int number)
        {
            Console.WriteLine(2*3*number);
        }
         static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());
            nevada process = new nevada(square);
            process+=cube;
            process+=circle;
            process(number);

        }
    }
}
