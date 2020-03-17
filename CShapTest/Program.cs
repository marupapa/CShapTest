using System;

namespace CShapTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fibonacci World!");

            Fibonacci(10);


        }

        private static void Fibonacci(int limit)
        {
            var x = 0;
            var y = 1;

            for (int i = 0; i < limit; i++)
            {

                int result = x + y;


                Console.WriteLine(String.Format("x:{0}, y:{1}, result:{2}", x, y, result));


                x = y;
                y = result;




            }

            /* 0,1,1,2,3,5,8,13 */

            /* 0,1,1
             x = 0
             y = x + 1
             result = x + y (1)
             */

            /* 1,1,2
            x = y (1)
            y = result (1)
            result = x + y (2)

             */
            /* 1,2,3
            x = y (1)
            y = result (2)
            result = x + y (3)
             */

            /* 2,3,5
            x = y (2)
            y = result (3)
            result = x + y (5)
             */


            /* 3,5,8
            x = y (3)
            y = result (5)
            result = x + y (8)
             */

        }
    }
}
