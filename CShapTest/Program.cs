using System;
using System.Threading.Tasks;

namespace CShapTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 与えられた整数の配列の中から足りない数字を探す */
            /*
            int[] arrayInt = new int[] { 1, 2, 3, 4, 5, 6, 8, 9 };

            int result = 0;
            for (int i = 0; i < arrayInt.Length - 1; i++)
            {
                if ((arrayInt[i] + 1) != arrayInt[i + 1])
                {
                    //Console.WriteLine("{0}", arrayInt[i]);

                    result = arrayInt[i] + 1;

                    break;
                }
            }

            Console.WriteLine("{0}", result);
            /*

            /* ソートされていない整数の配列から最大値と最小値を探す */
            //int[] arrayInt = new int[] { 3, 6, 5, 4, 8, 9, 10, 13 };

            //int nMin = 0, nMax = 0;

            //for (int x = 0; x < arrayInt.Length; x++)
            //{
            //    nMin = arrayInt[x];
            //    nMax = arrayInt[x];

            //    for (int i = 0; i < arrayInt.Length; i++)
            //    {
            //        /*最小数*/
            //        if (nMin > arrayInt[i]) nMin = arrayInt[i];
            //        /*最大数*/
            //        if (nMax < arrayInt[i]) nMax = arrayInt[i];
            //    }
            //}

            //Console.WriteLine("{0} : {1}", nMin, nMax);

            /* 合計すると与えられた数字と同じになる整数の配列のすべての組み合わせ */
            int[] array = new int[] { 3, 6, 5, 4, 8, 9, 10, 13 };

            int nSumValue = 23;
            int nValue = 0;
            int nSumResult = 0;
            for (int x = 0; x < array.Length - 1; x++)
            {
                nValue = array[x];
                for (int i = 1; i < array.Length; i++)
                {

                    nSumResult = nValue + array[i];

                    if (nSumValue.Equals(nSumResult))
                    {
                        Console.WriteLine("{0} + {1} = {2} ", nValue, array[i], nSumResult);


                        break;
                    }


                }

            }

            //Console.WriteLine("{0} ", nSumResult);





            //Console.WriteLine("{0}, Hello Fibonacci World!", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));


            //Task t1 = new Task(() =>
            //{

            //    Fibonacci(20);

            //});



            //Task t2 = new Task(() =>
            //{
            //    int toValue = 20;
            //    for (int i = 1; i <= toValue; i++)
            //    {
            //        fibo(i);
            //        //Console.WriteLine("{0} ", fibo(i));
            //    }
            //});



            // Task 쓰레드 시작
            //t1.Start();
            //t2.Start();

            // Task가 끝날 때까지 대기
            //t1.Wait();
            //t2.Wait();






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

