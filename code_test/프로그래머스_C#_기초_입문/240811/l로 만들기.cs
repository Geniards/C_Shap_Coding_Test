using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240811
{
    #region l로 만들기
    /*
     * 문제 설명
     *   알파벳 소문자로 이루어진 문자열 myString이 주어집니다. 
     *   알파벳 순서에서 "l"보다 앞서는 모든 문자를 
     *   "l"로 바꾼 문자열을 return 하는 solution 함수를 완성해 주세요.
     *   
     *
     *
     *제한사항
     *     1 ≤ myString ≤ 100,000
     *     myString은 알파벳 소문자로 이루어진 문자열입니다.
     *      
     *      
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class l로_만들기
    {
        static public string solution(string myString)
        {
            string answer = "";
            char[] chars = myString.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] < 'l')
                    chars[i] = 'l';
                sb.Append(chars[i]);
            }
            answer = sb.ToString();

            return answer;
        }
    }
}
