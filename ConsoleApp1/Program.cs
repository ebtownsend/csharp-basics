using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Operations op = new Operations();

            op.message();
            op.addition(5, 10);

            op.salarySlip(2000);
            op.salarySlip(1500);

            Math math = new Math();

            Console.WriteLine("Result of add is " + math.add(1, 1));
            Console.WriteLine("Result of subtract is " + math.sub(2, 1));
            Console.WriteLine("Result of multiplication is " + math.multi(5, 10));
            Console.WriteLine("Result of divide is " + math.div(10, 2));

            Console.Read();
        }
    }
}
