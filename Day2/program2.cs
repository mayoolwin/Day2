using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class program2
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a + b);

            double c = 70.8;
            double d = 170.1;
            Console.WriteLine(c + d);

            Console.WriteLine(a + c);

            Console.Write("He weights {0} kg and is {1} cm tall",c,d);

            Console.Write("He weights {0:0.000} kg and is {1:0.000} cm tall", c, d);

            double balance = 12345.678912345;
            double bigbalance = 1234567812345;
            Console.WriteLine("${0}", balance);
            Console.WriteLine("${0:0,000.00}", balance);


            Console.WriteLine("${0:0,000.00}", bigbalance);
            Console.WriteLine("${0:0,0.00}", bigbalance);

            double x = 123;
            double y = 33.334;
            Console.WriteLine("{0}  {1}" , x, y);//123     33.334
            Console.WriteLine("{0:0.0}  {1:0.0}" , x, y);//123.0     33.3
            Console.WriteLine("{0:#.#}  {1:#.#}" , x, y);//123     33.3
          

            Console.Write("{0:00000}", x); //00123
            Console.WriteLine("{0:00}", x); //123
            Console.WriteLine("{0:###00}", x); //123 (# is optional)



        }
        
    }
}
