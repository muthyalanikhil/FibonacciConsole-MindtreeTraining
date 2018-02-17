using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibbnoci
{
    class Fib
    {
        public void logic()
        {
            try
            {
                int n, a = 0, b = 1, temp;
                Console.WriteLine("enter value of n:");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(1);
                for (int i = 1; i < n; i++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;
                    Console.WriteLine(temp);
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }
          

        }
    }
}
