using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240820
{
    #region 가운데 글자 가져오기(12903)

    /*
     * 문제 설명
     *   단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요. 
     *   단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.
     *   
     * 제한사항
     *   s는 길이가 1 이상, 100이하인 스트링입니다.
     *
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class 가운데_글자_가져오기_12903_
    {
        static public string solution(string s)
        {
            string answer = "";

            if (s.Length % 2 == 1)
                answer = s.Substring(s.Length / 2, 1);
            else
                answer = s.Substring(s.Length / 2 - 1, 2);


            return answer;
        }
    }
}
