using System;
using System.Collections.Generic;

namespace CShapTest
{
    public class ProgrammersTest
    {
        public ProgrammersTest()
        {
        }

        /*
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

            List<int> arrResult = new List<int>();  //체육복을 대여한 학생 리스lostItem - 1)
            List<int> lostList = new List<int>();
            lostList.AddRange(lost);
            List<int> reserveList = new List<int>();
            reserveList.AddRange(reserve);

            int lostLenth = lost.Length;
            int reserveLenth = reserve.Length;

            if ((30 > n && n >= 2)
                && (n > lostLenth && lostLenth >= 1)
                && (n > reserveLenth || reserveLenth >= 1))
            {
                /*
                 * 체육복을 안 가져온 학생중에 체육복을 빌리는 것이 가능한 학생수를 구하는 루프
                 */
                //foreach (int lostItem in lostList)
                //{
                //    if (!arrResult.Contains(lostItem - 1) && reserveList.Contains((lostItem - 1)))
                //    {
                //        arrResult.Add(lostItem - 1);
                //    }
                //    else if (!arrResult.Contains(lostItem + 1) && reserveList.Contains((lostItem + 1)))
                //    {
                //        arrResult.Add(lostItem + 1);
                //    }

                //    if (reserveList.Contains(lostItem)) arrResult.Remove(lostItem);
                //}

                for (int i = 0; i < lostLenth; i++)
                {
                    /* 체육복을 잃어버린 학생 */
                    int lostItem = lost[i];

                    for (int j = 0; j < reserveLenth; j++)
                    {
                        if (!arrResult.Contains(reserve[j]))
                        {
                            if ((lostItem - 1).Equals(reserve[j]))
                            {
                                arrResult.Add(lostItem - 1);
                                break;
                            }
                            else if ((lostItem + 1).Equals(reserve[j]))
                            {
                                arrResult.Add(lostItem + 1);
                                break;
                            }
                        }
                    }
                }

                /* answer = 총학생수 - 체육복을 안가져온 학생수 + 채육복을 빌리는게 가능한 학생수 */
                answer = n - lostLenth + (arrResult.Count);
            }
            else answer = -1;

            return answer;
        }
    }
}
