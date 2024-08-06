using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240806
{
    #region rny_string
    /*
     * 문제 설명
     *      'm'과 "rn"이 모양이 비슷하게 생긴 점을 활용해 문자열에 장난을 하려고 합니다. 
     *      문자열 rny_string이 주어질 때, 
     *      rny_string의 모든 'm'을 "rn"으로 바꾼 문자열을
     *      return 하는 solution 함수를 작성해 주세요.
     *      
     *      
     * 제한사항
     *      1 ≤ rny_string의 길이 ≤ 100
     *      rny_string은 영소문자로만 이루어져 있습니다.
     *      
     *      
     * 문제해결
     *      -
     */
    #endregion

    public class rny_string
    {
        static public string solution(string rny_string)
        {
            string answer = rny_string.Replace("m", "rn");


            return answer;
        }
    }
}
