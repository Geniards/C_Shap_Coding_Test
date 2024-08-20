using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240820
{
    #region 핸드폰 번호 가리기(12948)

    /*
     * 문제 설명
     *   프로그래머스 모바일은 개인정보 보호를 위해 고지서를 보낼 때 
     *   고객들의 전화번호의 일부를 가립니다.
     *   전화번호가 문자열 phone_number로 주어졌을 때, 
     *   전화번호의 뒷 4자리를 제외한 나머지 숫자를 전부 *으로 가린 문자열을 리턴하는 함수, 
     *   solution을 완성해주세요.
     *   
     * 제한사항
     *   phone_number는 길이 4 이상, 20이하인 문자열입니다.
     *
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class 핸드폰_번호_가리기_12948_
    {
        static public string solution(string phone_number)
        {
            string answer = "";
            int temp = phone_number.Length;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < temp - 4; i++)
                sb.Append("*");

            sb.Append(phone_number.Skip(temp - 4).ToArray());

            return answer = sb.ToString();
        }
    }
}
