using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 뒤에서 5등까지
    /*
     * 문제 설명
     *    정수로 이루어진 리스트 num_list가 주어집니다. 
     *    num_list에서 가장 작은 5개의 수를 오름차순으로 담은 리스트를
     *    return하도록 solution 함수를 완성해주세요.
     *
     *
     *제한사항
     *      6 ≤ num_list의 길이 ≤ 30
     *      1 ≤ num_list의 원소 ≤ 100
     *      
     *      
     * 문제해결
     *      Array.Sort()를 사용.
     *      
     *      
     */
    #endregion
    public class 뒤에서_5등까지
    {
        static public int[] solution(int[] num_list)
        {
            int[] answer = new int[5];

            Array.Sort(num_list);
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = num_list[i];
            }



            return answer;
        }
    }
}
