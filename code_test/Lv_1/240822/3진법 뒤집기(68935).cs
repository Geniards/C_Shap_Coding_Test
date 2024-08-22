using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240822
{
    #region 3진법 뒤집기(68935)

    /*
     * 문제 설명
     *   자연수 n이 매개변수로 주어집니다. n을 3진법 상에서 앞뒤로 뒤집은 후, 
     *   이를 다시 10진법으로 표현한 수를 return 하도록 solution 함수를 완성해주세요.
     *   
     *   
     *   
     * 제한사항
     *   n은 1 이상 100,000,000 이하인 자연수입니다.
     *
     * 문제해결
     *      너무 어렵게 생각하지 말자.
     *      
     *      
     */
    #endregion
    public class _3진법_뒤집기_68935_
    {
        static public double solution(int n)
        {
            double answer = 0;
            List<int> list = new List<int>();

            while (n != 0)
            {
                list.Add(n % 3);

                n /= 3;
            }

            for (int i = 0; i < list.Count; i++)
            {
                answer += list[i] * Math.Pow(3, list.Count - 1 - i);
            }

            return answer;
        }
    }
}
