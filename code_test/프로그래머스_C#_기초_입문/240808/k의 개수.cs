using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region k의 개수
    /*
     * 문제 설명
     *    1부터 13까지의 수에서, 1은 1, 10, 11, 12, 13 이렇게 총 6번 등장합니다. 
     *    정수 i, j, k가 매개변수로 주어질 때, 
     *    i부터 j까지 k가 몇 번 등장하는지 return 하도록 solution 함수를 완성해주세요.
     *
     *
     *제한사항
     *      1 ≤ i < j ≤ 100,000
     *      0 ≤ k ≤ 9
     *      
     *      
     * 문제해결
     *      Covert형변환 후 Contains를 사용해서 풀었다.
     *      
     *      
     */
    #endregion
    public class k의_개수
    {
        static public int solution(int i, int j, int k)
        {
            int answer = 0;

            for (int temp = i; temp <= j; ++temp)
            {
                string str = Convert.ToString(temp);
                for (int temp2 = 0; temp2 < str.Length; temp2++)
                {
                    if (str[temp2].ToString().Contains(Convert.ToString(k)))
                        answer++;
                }

            }

            return answer;
        }
    }
}
