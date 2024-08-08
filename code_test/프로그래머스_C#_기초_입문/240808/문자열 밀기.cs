using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 문자열 밀기
    /*
     * 문제 설명
     *    문자열 "hello"에서 각 문자를 오른쪽으로 한 칸씩 밀고 
     *    마지막 문자는 맨 앞으로 이동시키면 "ohell"이 됩니다. 
     *    이것을 문자열을 민다고 정의한다면 
     *    문자열 A와 B가 매개변수로 주어질 때, 
     *    
     *    A를 밀어서 B가 될 수 있다면 밀어야 하는 
     *    최소 횟수를 return하고 밀어서 B가 될 수 없으면 -1을 
     *    return 하도록 solution 함수를 완성해보세요.
     *
     *
     *제한사항
     *      0 < A의 길이 = B의 길이 < 100
     *      A, B는 알파벳 소문자로 이루어져 있습니다.
     *      
     *      
     * 문제해결
     *      시야를 넓혀야할듯 하다.. 다른 사람들의 풀이는 항상 놀랍다....
     *      
     *      
     */
    #endregion
    public class 문자열_밀기
    {
        static public int solution(string A, string B)
        {
            #region 내풀이
            int answer = 0;
            int temp = A.Length;

            if (A == B)
                return answer;

            while (temp > 0)
            {
                string s = A.Substring(A.Length - 1, 1);
                A = A.Substring(0, A.Length - 1);
                A = A.Insert(0, s);

                answer++;
                if (A == B)
                {
                    break;
                }
                temp--;
            }

            if (A != B)
                answer = -1;

            return answer;
            #endregion

            #region 다른사람 풀이
            //int answer = (B + B).IndexOf(A);
            return answer;
            #endregion
        }
    }
}
