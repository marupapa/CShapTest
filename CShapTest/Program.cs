using System;
using System.Threading.Tasks;

namespace CShapTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}, Hello Fibonacci World!", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));


            Task t1 = new Task(() =>
            {
                Console.WriteLine(String.Format("t1 >>> {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt")));

                Fibonacci(20);

                Console.WriteLine(String.Format("t1 >>> {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt")));
            });



            Task t2 = new Task(() =>
            {
                Console.WriteLine(String.Format("t2 >>> {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt")));

                int toValue = 20;
                for (int i = 1; i <= toValue; i++)
                {
                    fibo(i);
                    //Console.WriteLine("{0} ", fibo(i));
                }

                Console.WriteLine(String.Format("t2 >>> {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt")));
            });



            // Task 쓰레드 시작
            t1.Start();
            t2.Start();

            // Task가 끝날 때까지 대기
            t1.Wait();
            t2.Wait();






        }
        static long fibo(int value)
        {
            if (value == 1 || value == 2)
            {
                return 1;
            }
            /*
            3(2 +1)


            )
             */

            //Console.WriteLine("{0}, {1}", fibo(value - 1), fibo(value - 2));

            return fibo(value - 1) + fibo(value - 2);
        }
        static void Fibonacci(int limit)
        {
            var x = 0;
            var y = 1;
            int result = 0;

            for (int i = 0; i < limit; i++)
            {

                result = x + y;


                //Console.WriteLine(String.Format("x:{0}, y:{1}, result:{2}", x, y, result));


                x = y;
                y = result;


            }
            Console.WriteLine(String.Format("{0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt")));
            

        }
    
    }
}

