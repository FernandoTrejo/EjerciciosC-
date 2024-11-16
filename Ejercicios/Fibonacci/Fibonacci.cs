using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Fibonacci
{
    internal class Fibonacci
    {
        public void Execute()
        {
            Int64 a = 0;
            Int64 b = 1;

            var i = 3;

            Console.WriteLine(a);
            Console.WriteLine(b);

            while (i <= 50)
            {
                Int64 c = a + b;
                Console.WriteLine(c);

                a = b;
                b = c;

                i++;
            }
        }
    }
}
