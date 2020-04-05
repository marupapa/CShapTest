using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace CShapTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /* solution 1 */
            //n = 30, lost = [2,30], reserve[2]
            // 5, [2, 4], [1, 3, 5]
            //int answer = ProgrammersTest.solution1(5, new int[] { 2, 4 }, new int[] { 1, 3, 5 });
            //int answer = ProgrammersTest.solution1(8, new int[] { 2, 3 }, new int[] { 3, 4 });


            /* solution 2 */
            //ProgrammersTest.solution2(new int[] { 1, 4, 3, 3, 4, 5, 6, 3, 2, 3, 3, 5 });
            //ProgrammersTest.solution2(new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 });

            /* solution 3 */
            //ProgrammersTest.solution3(7);


            /* solution 4 */
            //ProgrammersTest.solution4(new int[] { 6, 9, 5, 7, 4 });


            /* solution truck */
            //ProgrammersTest.solution_truck(4, 11, new int[] { 7, 4, 5, 6, 8 });



            /* solution printer */
            //ProgrammersTest.solution_printer(new int[] { 2, 1, 3, 2 }, 2);
            ProgrammersTest.solution_printer(new int[] { 1, 1, 9, 1, 1, 1 }, 0);



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
            //int[] array = new int[] { 3, 6, 5, 4, 8, 9, 10, 13 };

            //int nSumValue = 23;
            //int nValue = 0;
            //int nSumResult = 0;
            //for (int x = 0; x < array.Length - 1; x++)
            //{
            //    nValue = array[x];
            //    for (int i = 1; i < array.Length; i++)
            //    {
            //        nSumResult = nValue + array[i];
            //        if (nSumValue.Equals(nSumResult))
            //        {
            //            Console.WriteLine("{0} + {1} = {2} ", nValue, array[i], nSumResult);
            //            break;
            //        }
            //    }

            //}
            //Console.WriteLine("{0} ", nSumResult);


            /* 配列に複数の重複がある場合、配列内の重複した数字を探す */
            //int[] array = new int[] { 1, 2, 3, 4, 4, 5, 7, 7 };

            //int resultNum = 0;

            //for (int x = 0; x < array.Length - 1; x++)
            //{
            //    if (array[x].Equals(array[x+1]))
            //    {
            //        resultNum = array[x];
            //        break;
            //    }

            //}

            //Console.WriteLine("resultNum : {0}", resultNum);

            //int[] array1 = new int[] { 1, 2, 3, 4, 5, 7 };
            //int[] array2 = new int[] { 6, 7, 8, 9, 0 };

            //List<int> result = new List<int>();


            //for (int x = 0; x < array1.Length; x++)
            //{
            //    int temp = array1[x];
            //    for (int i = 0; i < array2.Length; i++)
            //    {
            //        //Console.WriteLine("{0}, {1}", temp, array2[i]);
            //        if (temp.Equals(array2[i])) result.Add(array2[i]);
            //    }       

            //}
            //Console.WriteLine(string.Join("\t", result));


            //int[] array = new int[] { 9, 4, 5, 7, 3, 2, 1, 6, 8 };

            //for (var i = 0; i < array.Length - 1; i++)
            //{
            //    for (var j = 0; j < array.Length - 1; j++)
            //    {


            //    }

            //}





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

