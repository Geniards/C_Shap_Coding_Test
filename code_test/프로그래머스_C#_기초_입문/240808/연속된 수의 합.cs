using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 연속된 수의 합
    /*
     * 문제 설명
     *    연속된 세 개의 정수를 더해 12가 되는 경우는 3, 4, 5입니다. 
     *    두 정수 num과 total이 주어집니다. 
     *    
     *    연속된 수 num개를 더한 값이 total이 될 때, 
     *    정수 배열을 오름차순으로 담아 return하도록 solution함수를 완성해보세요.
     *
     *
     *제한사항
     *      1 ≤ num ≤ 100
     *      0 ≤ total ≤ 1000
     *      num개의 연속된 수를 더하여 total이 될 수 없는 테스트 케이스는 없습니다.
     *      
     *      
     * 문제해결
     *      그냥 풀렸다...
     *      
     *      
     */
    #endregion
    public class 연속된_수의_합
    {
        static public int[] solution(int num, int total)
        {
            int[] answer = new int[num];

            int temp = total / num;
            int temp_num = total % num;
            int halflen = num / 2;

            for (int i = 0; i < num; i++)
            {

                answer[i] = temp - halflen;

                if (temp_num > 0)
                    answer[i] += 1;

                halflen--;
            }

            return answer;
        }
    }
}
