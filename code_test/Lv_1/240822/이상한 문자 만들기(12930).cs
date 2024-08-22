using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240822
{
    #region 이상한 문자 만들기(12930)

    /*
     * 문제 설명
     *   문자열 s는 한 개 이상의 단어로 구성되어 있습니다. 
     *   각 단어는 하나 이상의 공백문자로 구분되어 있습니다. 
     *   각 단어의 짝수번째 알파벳은 대문자로, 
     *   홀수번째 알파벳은 소문자로 바꾼 문자열을 리턴하는 함수, solution을 완성하세요.
     *   
     *   
     *   
     * 제한사항
     *   문자열 전체의 짝/홀수 인덱스가 아니라, 단어(공백을 기준)별로 짝/홀수 인덱스를 판단해야합니다.
     *   첫 번째 글자는 0번째 인덱스로 보아 짝수번째 알파벳으로 처리해야 합니다.
     *
     * 문제해결
     *      문제 설명을 제대로 파악하자.
     *      
     *      
     */
    #endregion
    public class 이상한_문자_만들기_12930_
    {
        static public string solution(string s)
        {
            string answer = "";
            StringBuilder sb = new StringBuilder();
            string[] strings = s.Split(" ");
            int num = 0;
            foreach (string str in strings)
            {
                num++;
                for (int i = 0; i < str.Length; i++)
                {
                    if (i % 2 == 0)
                        sb.Append(str[i].ToString().ToUpper());
                    else
                        sb.Append(str[i].ToString().ToLower());
                }

                if (num != strings.Length)
                    sb.Append(" ");
                else
                    break;
            }

            return answer = sb.ToString();
        }
    }
}
