using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region A로 B 만들기
    /*
     * 문제 설명
     *    문자열 before와 after가 매개변수로 주어질 때, 
     *    before의 순서를 바꾸어 after를 만들 수 있으면 1을, 
     *    만들 수 없으면 0을 return 하도록 solution 함수를 완성해보세요.
     *
     *
     *제한사항
     *      0 < before의 길이 == after의 길이 < 1,000
     *      before와 after는 모두 소문자로 이루어져 있습니다.
     *      
     *      
     * 문제해결
     *      IsNullOrEmpty() 공백이("") 존재하면 true;
     *      IsNullOrWhiteSpace() 공백문자가("  ") 존재하면 true;
     *      
     *      
     */
    #endregion
    public class A로_B_만들기
    {
        static public int solution(string before, string after)
        {
            #region 내풀이
            int answer = 0;
            char[] chars = before.ToCharArray();


            for (int i = 0; i < chars.Length; i++)
            {
                if (after.Contains(chars[i]))
                    after = after.Remove(after.IndexOf(chars[i]), 1);
            }

            if (string.IsNullOrEmpty(after))
                answer = 1;
            else
                answer = 0;

            return answer;
            #endregion

            #region 다른 사람 풀이
            //int answer = 0;
            //char[] beforeArr = before.ToCharArray();
            //char[] afterArr = after.ToCharArray();
            //Array.Sort(beforeArr);
            //Array.Sort(afterArr);
            //for (int i = 0; i < beforeArr.Length; i++)
            //{
            //    if (beforeArr[i] != afterArr[i])
            //        return 0;
            //}
            //return 1;
            #endregion
        }
    }
}
