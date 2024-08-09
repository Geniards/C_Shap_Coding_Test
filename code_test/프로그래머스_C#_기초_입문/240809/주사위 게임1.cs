using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240809
{
    #region 주사위 게임1
    /*
     * 문제 설명
     *    1부터 6까지 숫자가 적힌 주사위가 두 개 있습니다. 
     *    두 주사위를 굴렸을 때 나온 숫자를 각각 a, b라고 했을 때 
     *    얻는 점수는 다음과 같습니다.
     *    
     *    a와 b가 모두 홀수라면 a2 + b2 점을 얻습니다.
     *    a와 b 중 하나만 홀수라면 2 × (a + b) 점을 얻습니다.
     *    a와 b 모두 홀수가 아니라면 |a - b| 점을 얻습니다.
     *    
     *    두 정수 a와 b가 매개변수로 주어질 때, 
     *    얻는 점수를 return 하는 solution 함수를 작성해 주세요.
     *
     *
     *제한사항
     *     a와 b는 1 이상 6 이하의 정수입니다.
     *      
     *      
     * 문제해결
     *      
     *      
     *      
     */
    #endregion
    public class 주사위_게임1
    {
        static public int solution(int a, int b)
        {
            int answer = 0;

            if (a % 2 != 0 && b % 2 != 0)
                answer = (int)(Math.Pow(a, 2) + Math.Pow(b, 2));
            else if (a % 2 != 0 || b % 2 != 0)
                answer = 2 * (a + b);
            else
                answer = Math.Abs(a - b);

            return answer;
        }
    }
}
