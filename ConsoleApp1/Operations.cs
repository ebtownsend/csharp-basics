using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Operations
    {
        public int no1, no2;

        public void message()
        {
            Console.WriteLine("Hi :)");
        }

        public void addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("The result of the addition is " + result);
        }

        public void salarySlip(int salary)
        {
            float tax, net;

            if (salary >= 2000 )
            {
                tax = salary * 20 / 100;
            } else
            {
                tax = salary * 10 / 100;
            }

            net = salary - tax;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Your salary is: " + salary);
            Console.WriteLine("Tax calculated is: " + tax);
            Console.WriteLine("Net salary is: " + net);
        }
    }
}
