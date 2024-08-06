using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240806
{
    #region 간단한식 계산하기
    /*
     * 문제 설명
     *      문자열 binomial이 매개변수로 주어집니다. 
     *      binomial은 "a op b" 형태의 이항식이고 
     *      a와 b는 음이 아닌 정수, op는 '+', '-', '*' 중 하나입니다. 
     *      주어진 식을 계산한 정수를 return 하는 solution 함수를 작성해 주세요.
     *      
     * 제한사항
     *      0 ≤ a, b ≤ 40,000
     *      0을 제외하고 a, b는 0으로 시작하지 않습니다.
     */
    #endregion

    public class Program
    {
        static public int solution(string binomial)
        {
            int answer = 0;
            string[] str = binomial.Split(' ');

            if (str[1] == "+")
                answer = int.Parse(str[0]) + int.Parse(str[2]);
            if (str[1] == "-")
                answer = int.Parse(str[0]) - int.Parse(str[2]);
            if (str[1] == "*")
                answer = int.Parse(str[0]) * int.Parse(str[2]);

            return answer;
        }
    }
}
