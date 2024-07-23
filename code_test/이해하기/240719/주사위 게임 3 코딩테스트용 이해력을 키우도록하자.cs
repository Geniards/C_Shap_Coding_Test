using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기
{
    internal class 주사위_게임_3_코딩테스트용_이해력을_키우도록하자
    {
        #region  주사위 게임 3   코딩테스트용 이해력을 키우도록하자.
        //static public int solution(int a, int b, int c, int d)
        //{
        //    int answer = 0;
        //    int[] dice = new int[6];
        //    int[] arr = new int[4] { a,b,c,d};

        //    dice[a - 1]++;
        //    dice[b - 1]++;
        //    dice[c - 1]++;
        //    dice[d - 1]++;

        //    int p = 0;
        //    int q = 0;
        //    int r = 0;
        //    int count = 0;
        //    int count2 = 0;

        //    for (int i = 0; i < 6; i++)
        //    {
        //        if (dice[i] == 4)
        //            p = i + 1;

        //        if (dice[i] == 3)
        //        {
        //            p = i + 1;

        //            if (q != 0)
        //                p = i + 1;
        //        }

        //        if (dice[i] == 2)
        //        {

        //            if (count != 0)
        //            {
        //                q = i + 1;
        //                break;
        //            }

        //            p = i + 1;
        //            count++;

        //        }

        //        if (dice[i] == 1)
        //        {
        //            if (count2 > 2)
        //                p = 1;
        //            if(q == 0)
        //                q = i + 1;
        //            else
        //                r = i + 1;
        //            count2++;
        //        }
        //    }


        //    if (count2 > 2)
        //    {
        //        Array.Sort(arr);
        //        answer = arr[0];
        //    }

        //    else if (dice[p-1] == 4)
        //        answer = 1111 * p;
        //    else if (dice[p-1] == 3)
        //        answer = (int)Math.Pow(10 * p + q, 2);
        //    else if (dice[p - 1] == 2 && count != 0 && count2 == 0)
        //        answer = (p + q) * Math.Abs(p - q);
        //    else if (dice[p - 1] == 2 && count2 != 0)
        //        answer = q * r;



        //    return answer;
        //}

        //static void Main(string[] args)
        //{
        //    int a = 2;
        //    int b = 5;
        //    int c = 2;
        //    int d = 6;

        //    Console.WriteLine($"{solution(a,b,c,d)}");
        //}
        #endregion
    }
}
