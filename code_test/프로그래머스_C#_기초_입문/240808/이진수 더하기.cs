using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 이진수 더하기
    /*
     * 문제 설명
     *    이진수를 의미하는 두 개의 문자열 bin1과 bin2가 매개변수로 주어질 때, 
     *    두 이진수의 합을 return하도록 solution 함수를 완성해주세요.
     *
     *
     *제한사항
     *      return 값은 이진수를 의미하는 문자열입니다.
     *      1 ≤ bin1, bin2의 길이 ≤ 10
     *      bin1과 bin2는 0과 1로만 이루어져 있습니다.
     *      bin1과 bin2는 "0"을 제외하고 0으로 시작하지 않습니다.
     *      
     *      
     * 문제해결
     *      Covert를 이용해서 형변환했다.
     *      
     *      
     */
    #endregion
    public class 이진수_더하기
    {
        static public string solution(string bin1, string bin2)
        {
            string answer = "";
            int a = 0;
            a = Convert.ToInt32(bin1, 2);
            a += Convert.ToInt32(bin2, 2);
            answer = Convert.ToString(a, 2);



            return answer;
        }
    }
}
