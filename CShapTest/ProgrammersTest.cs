using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;

namespace CShapTest
{
    public class ProgrammersTest
    {
        public ProgrammersTest()
        {
        }
        static public int[] solution_stock(int[] prices)
        {
            int[] answer = new int[] { };
            return answer;
        }
        /* 自分のプリントアウト順番を出力せよ
        プリント優先順位の配列prioritiesと自分のプリント物の配列内の場所を示すlocationが引数としてあたえられたら、
        自分のプリントは何番目に出力されるのかを求めよう。
         */
        public class StructPrinter
        {
            public int index { get; set; }
            public int prioritie { get; set; }
        }
        static public int solution_printer(int[] priorities, int location) {
            int answer = 0;

            ConcurrentQueue<StructPrinter> prior = new ConcurrentQueue<StructPrinter>();
            for (int i = 0; i < priorities.Length; i++)
            {
                prior.Enqueue(new StructPrinter()
                {
                    index = i,
                    prioritie = priorities[i]
                });
            }

            while (!prior.IsEmpty)
            {
                StructPrinter peekResult = (prior.TryPeek(out peekResult)) ? peekResult : null;
                StructPrinter dequeue = (prior.TryDequeue(out dequeue)) ? dequeue : null;

                int max = 0;
                foreach(var item in prior)
                    if (max < item.prioritie) max = item.prioritie;

                if (peekResult.prioritie < max)
                {
                    prior.Enqueue(dequeue);
                }
                else
                {
                    answer++;
                    if (peekResult.index.Equals(location))
                    {
                        //Console.WriteLine("index, prioritie, answer : {0}, {1}, {2}", peekResult.index, peekResult.prioritie, answer);
                        return answer;
                    }
                }
                //Console.WriteLine("prior : " + string.Join(",", prior.ToList()));
            }


            Console.WriteLine("answer : {0}", answer);
            return answer;
        }

        /*
        トラック数台川を横切ること車線の橋を決められた順に渡ろうします。
        すべてのトラックが橋を渡っては、最小数秒かかる把握する必要があります。
        トラックは1秒に1だけ動き、脚の長さはbridge_lengthで足は重量weightまで耐えます。
        ※トラックが足に完全に上がらない場合は、このトラックの重量は考慮していません。
        例えば、長さが2であり、10kg重量に耐える橋があります。
        重量が[7、4、5、6] kgであるトラックが順番に最短時間で橋を渡ってするには、次のように渡らなければします。
        */
        static public int solution_truck(int bridge_length, int weight, int[] truck_weights)
        {
            int answer = 0;
            
            /* 橋のキュー */
            ConcurrentQueue<int> bridge = new ConcurrentQueue<int>();
            /*橋を渡ろうとしているトラックのキュー*/
            ConcurrentQueue<int> qTruckList = new ConcurrentQueue<int>();

            for (int i = 0; i < truck_weights.Length; i++)
                qTruckList.Enqueue(truck_weights[i]);

            ConcurrentQueue<int> exitTruckList = new ConcurrentQueue<int>();

            while(!qTruckList.IsEmpty)
            {
                answer++;

                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("qTruckList : " + string.Join(",", qTruckList));
                /* 橋に進入するトラックの重さ */
                int truckWeight = (qTruckList.TryDequeue(out truckWeight)) ? truckWeight : 0;

                Console.WriteLine("weight >>>>:{0}", weight);
                Console.WriteLine("truckWeight >>>>:{0}", truckWeight);
                Console.WriteLine("bridge.Sum() >>>>:{0}", bridge.Sum());
                Console.WriteLine("bridge.Count >>>>:{0}", bridge.Count);

                /* 橋にあるトラックの重さと進入トラックの重さ比較 */
                // if (truckWeight < (weight - bridge.Sum()) && bridge_length > bridge.Count) {
                //     bridge.Enqueue(truckWeight); /*トラックが橋に進入*/
                //     answer = answer + bridge_length;
                // }
                /*トラックが橋に進入*/
                bridge.Enqueue(truckWeight); 
                //answer = answer + bridge_length;

                while(!qTruckList.IsEmpty)
                {
                    answer++;










                    /*次のトラックが橋に進入可能なら進入させる*/
                    int inBridge = (qTruckList.TryPeek(out inBridge)) ? inBridge : 0;
                    if (inBridge <= (weight - bridge.Sum()) && bridge_length > bridge.Count) 
                    {
                        /*待機トラックキューから削除*/
                        int tryDequeue = (qTruckList.TryDequeue(out tryDequeue)) ? tryDequeue : 0;
                        /*トラックが橋に進入*/
                        bridge.Enqueue(inBridge); 
                        answer++;
                    }
                    


                    // /*トラックが橋から降りる*/
                    // if(bridge.Count.Equals(2))
                    // {
                    //     int exitBridge = (bridge.TryDequeue(out exitBridge)) ? exitBridge : 0;
                    //     bridge.Enqueue(exitBridge); 
                    //     answer++;
                    //     exitTruckList.Enqueue(exitBridge);
                    // }



                    Console.WriteLine("bridge >>>>>> : " + string.Join(",", bridge));



                    
                    /*トラックが進入できるかと橋に空きがあるかをチェック*/
                    // if (truckPeek <= (weight - bridge.Sum()) && bridge_length > bridge.Count) 
                    // {
                    //     if(!truckPeek.Equals(0))
                    //     {
                    //         int tryDequeue = (qTruckList.TryDequeue(out tryDequeue)) ? tryDequeue : 0;
                    //         bridge.Enqueue(truckPeek); /*トラックが橋に進入*/

                    //         answer++;
                    //     }
                    // }
                    // else break;
                }
                

                /* 橋からトラックが出る */
                // foreach(var item in bridge)
                // {
                //     int tryDequeue = (bridge.TryDequeue(out tryDequeue)) ? tryDequeue : 0;
                //     //Console.WriteLine("橋から降りたトラック番号 >>>>:{0}", tryDequeue);
                //     exitTruckList.Enqueue(tryDequeue);

                // }

                //bridge.Clear();
                //Console.WriteLine("exitTruckList : " + string.Join(",", exitTruckList));
            }

        
        
            // List<int> list = new List<int>();
            // for (int i = 0; i < truck_weights.Length; i++)
            // {
            //     list.Add(truck_weights[i]);
            //     if (i != (truck_weights.Length - 1)) /* 맨 마지막 트럭여부 체크 */
            //     {
            //         if ((truck_weights[i] + truck_weights[i + 1]) > weight)
            //         {
            //             for (int j = 1; j < bridge_length; j++) list.Add(0);
            //         }
            //     }
            // }

            // answer = list.Count + bridge_length;
        

            Console.WriteLine("answer  >>>>:{0}", answer);
            return answer;
        }
        /*
        水平直線のトップN台を立てました。すべての塔の頂上には、信号を送信/受信する装置を設置しました。
        発射された信号は、信号を送信塔よりも高い塔のみ受信します。また、一度受信した信号は、他の塔に送信されません。
        例えば、高さが6、9、5、7、4人5塔が左に同時にレーザー信号を発射します。それでは、トップは次のように信号を送受信します。
        高さが4である5番目の塔から発射された信号は、高さが7の4番目の塔が受信し、
        高さが7の4番目の塔の信号は、高さが9人第二塔が、
        高さが5である第三の塔の信号も高さが9である第二の塔が受信します。
        高さが9である第二の塔と高さが6人の最初の塔が送信レーザー信号はどのタワーも受信することができません。

        一番左から順にトップの高さを盛り込んだ配列heightsがパラメータとして与えられるとき、
        各塔が撮影した信号を、どのタワーから受けたのか記録した配列をreturnするようにsolution関数を作成してください。
        */

        static public int[] solution4(int[] heights)
        {
            int[] answer = new int[] { };
            Console.WriteLine("answer : " + string.Join(",", answer));

            List<int> tempAnswer = new List<int>();

            foreach(int item in heights)
            {
                tempAnswer.Add(0);
            }

            /* loof count 전체길이에 배열인덱스를 구하기 위해 1을 빼준다 */
            int i = heights.Length - 1;
            while (i > 0)
            {

                /* 상위 loof 보다 한자리 적은 숫자부터 시작해야 하기때문에 i-1 */
                int j = i - 1; /* loof count */
                while (j >= 0)
                {
                    if (heights[j] > heights[i])
                    {
                        Console.WriteLine(">i:{0}", heights[i]);
                        Console.WriteLine(">>i:{0}, j;{1}", i, j + 1);
                        // Console.WriteLine(">>i:{0}, j;{1}", heights[i], heights[j]);
                        //isAcept = true;
                        //tempAnswer.Add(j + 1);
                        tempAnswer[i] = j + 1;

                        //answer[i] = j + 1;


                        break;
                    }
                    j--;
                }


                i--;
            }

            answer = tempAnswer.ToArray();

            Console.WriteLine("answer : " + string.Join(",", answer));

            return answer;
        }


        /*
         *長さがnであり、数拍手拍手拍手....のようなパターンを維持する文字列を返す関数、solutionを完成します。
         * 例えば、nが4であればスイカスイカを返し、3であれば、数拍手を返しします。
         */
        static public string solution3(int n)
        {
            string answer = "";

            string[] word = { "수", "박" };

            for (int i = 0; i < n; i++)
            {
                answer = answer + word[(i % 2)];
            }


            return answer;
        }
        /*
        수포자는 수학을 포기한 사람의 준말입니다.
        수포자 삼인방은 모의고사에 수학 문제를 전부 찍으려 합니다.
        수포자는 1번 문제부터 마지막 문제까지 다음과 같이 찍습니다. 

        1번 수포자가 찍는 방식: 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, ... 
        2번 수포자가 찍는 방식: 2, 1, 2, 3, 2, 4, 2, 5, 2, 1, 2, 3, 2, 4, 2, 5, ... 
        3번 수포자가 찍는 방식: 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, 3, 3, 1, 1, 2, 2, 4, 4, 5, 5, … 


        1번 문제부터 마지막 문제까지의 정답이 순서대로 들은 배열 answers가 주어졌을 때,
        가장 많은 문제를 맞힌 사람이 누구인지 배열에 담아 return 하도록 solution 함수를 작성해주세요. 

             */
        static public int[] solution2(int[] answers) //{ 1,2,3,4,5}
        {
            int[] answer = new int[] { };

            /* 수포자 찍기 패턴 */
            int[] answerPattern1 = { 1, 2, 3, 4, 5 };
            int[] answerPattern2 = { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] answerPattern3 = { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };


            int[] answerCnt = new int[3] { 0, 0, 0 };
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i].Equals(answerPattern1[i % answerPattern1.Length]))
                    answerCnt[0]++;

                if (answers[i].Equals(answerPattern2[i % answerPattern2.Length]))
                    answerCnt[1]++;

                if (answers[i].Equals(answerPattern3[i % answerPattern3.Length]))
                    answerCnt[2]++;

                Console.WriteLine("{0}, {1}", answers[i], answerPattern1[i % answerPattern1.Length]);
            }
            Console.WriteLine("answerCnt1:{0}, answerCnt2:{1}, answerCnt3:{2}", answerCnt[0], answerCnt[1], answerCnt[2]);

            int bicScore = answerCnt[0];
            for (int i = 1; i < answerCnt.Length; i++)
            {
                if (bicScore < answerCnt[i])
                {
                    bicScore = answerCnt[i];
                }
            }

            Console.WriteLine("bicScore:{0}", bicScore);

            List<int> tempAnswer = new List<int>();
            for (int i = 0; i < answerCnt.Length; i++)
            {

                if (bicScore.Equals(answerCnt[i]))
                {
                    Console.WriteLine(">>>:{0}, {1}", i, answerCnt[i]);
                    tempAnswer.Add(i+1);

                }
            }


            //for (int i = 1; i < answerCnt.Length; i++)
            //{
            //    bicScore.Equals(answerCnt[i])
            //}

            //ArrayList al = new ArrayList();









            answer = tempAnswer.ToArray();


            Console.WriteLine("answer :" + string.Join("\t", tempAnswer));


            return answer;
        }
        /*
         * solution1
         * 
        問題の説明
        昼休みに泥棒が入って、いくつかの学生が体操服を盗まれました。
        幸いなことに掛け替え体操服がある学生は、これらの者に体操服を借りうとします。
        学生の数は、体格の順に付けられており、目の前番号の学生やすぐ裏番号の学生のみ体操服を貸すことができます。
        例えば、4回学生は、3回学生や5番学生のみ・体操服を貸すことができます。
        体操服がなければ授業を聞くことができないので、体操服を適切に借り、できるだけ多くの学生が体育の授業を聞かなければします。
        全体の学生の数n、体操服を盗まれた学生の数が込められた配列lost、掛け替えの体操服をもたらした学生の数が入った配列reserveがパラメータとして与えられるとき、体育の授業を聞くことができる学生の最大値をreturnするsolution関数を作成してください。
        制限事項 全体の学生の数は、2人以上の30人以下です。
        体操服を盗まれた学生の数は、1人以上のn人以下であり、重複する番号はありません。
        掛け替えの体操服をもたらした学生の数は、1人以上のn人以下であり、重複する番号はありません。
        掛け替え体操服がある学生が、他の学生に体操服を貸すことができます。
        掛け替え体操服をもたらした学生が体操服を盗まれています。
        この時、この学生は、体操服を1つだけ盗まれたと仮定し、残りの体操服が一つなので、他の学生には、体操服を貸すことができません。
        */
        static public int solution1(int n, int[] lost, int[] reserve)
        {
            int answer = 0;

            List<int> lostList = new List<int>();
            lostList.AddRange(lost);
            List<int> reserveList = new List<int>();
            reserveList.AddRange(reserve);

            List<int> listReserve = new List<int>();  //대여받은 학생 리스트.

            int lostLenth = lost.Length;
            int reserveLenth = reserve.Length;

            if ((30 >= n && n >= 2)
                && (n > lostLenth && lostLenth >= 1)
                && (n > reserveLenth || reserveLenth >= 1))
            {

                for (int i = 0; i < lostLenth; i++)
                {
                    for (int j = 0; j < reserveLenth; j++)
                    {
                        if (lost[i].Equals(reserve[j]))
                        {
                            lostList.Remove(reserve[j]);
                            reserveList.Remove(reserve[j]);
                        }
                    }
                }


                Console.WriteLine("lostList" + string.Join("\t", lostList));
                Console.WriteLine("reserveList" + string.Join("\t", reserveList));

                /*
                 * 체육복을 안 가져온 학생중에 체육복을 빌리는 것이 가능한 학생수를 구하는 루프
                 */
                foreach (int lostItem in lostList)
                {
                    if (!listReserve.Contains(lostItem - 1) && reserveList.Contains((lostItem - 1)))
                    {
                        listReserve.Add(lostItem - 1);
                    }
                    else if (!listReserve.Contains(lostItem + 1) && reserveList.Contains((lostItem + 1)))
                    {
                        listReserve.Add(lostItem + 1);
                    }
                }


                /* answer = 총학생수 - 체육복을 안가져온 학생수 + 채육복을 빌리는게 가능한 학생수 */
                Console.WriteLine("n :{0}, lost:{1}, reserve:{2}", n, lostList.Count, listReserve.Count);
                answer = n - lostList.Count + listReserve.Count;
            }
            else answer = -1;



            return answer;
        }
    }
}
