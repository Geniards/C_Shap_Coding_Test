using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 다음에 올 숫자
    /*
     * 문제 설명
     *    등차수열 혹은 등비수열 common이 매개변수로 주어질 때, 
     *    마지막 원소 다음으로 올 숫자를 return 하도록 solution 함수를 완성해보세요.
     *
     *
     *제한사항
     *      2 < common의 길이 < 1,000
     *      -1,000 < common의 원소 < 2,000
     *      common의 원소는 모두 정수입니다.
     *      등차수열 혹은 등비수열이 아닌 경우는 없습니다.
     *      등비수열인 경우 공비는 0이 아닌 정수입니다.
     *      
     *      
     * 문제해결
     *      앞의 3개만 확인하면 된다.
     *      수학공부를 많이 해야할듯하다.
     *      
     *      
     */
    #endregion
    public class 다음에_올_숫자
    {
        static public int solution(int[] common)
        {
            int answer = 0;

            // 등차수열
            if (common[2] - common[1] == common[1] - common[0])
            {
                answer = common[common.Length - 1] + (common[1] - common[0]);
            }
            // 등비수열
            else
            {
                answer = common[common.Length - 1] * (common[1] / common[0]);
            }


            return answer;
        }
    }
}
