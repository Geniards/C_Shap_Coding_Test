using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240820
{
    #region 약수의 개수와 덧셈(77884)

    /*
     * 문제 설명
     *   두 정수 left와 right가 매개변수로 주어집니다. 
     *   left부터 right까지의 모든 수들 중에서, 
     *   약수의 개수가 짝수인 수는 더하고, 
     *   약수의 개수가 홀수인 수는 뺀 수를 return 하도록 solution 함수를 완성해주세요.
     *   
     * 제한사항
     *   1 ≤ left ≤ right ≤ 1,000
     *
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class 약수의_개수와_덧셈_77884_
    {
        static public int solution(int left, int right)
        {
            int answer = 0;
            int count = 0;

            for (int i = left; i <= right; i++)
            {
                int temp = 1;

                while (i >= temp)
                {
                    if (i % temp == 0)
                        count++;
                    temp++;
                }

                if (count % 2 != 1)
                    answer += i;
                else
                    answer -= i;

                count = 0;

            }


            return answer;
        }
    }
}
