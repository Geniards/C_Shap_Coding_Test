using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240811
{
    #region 조건에 맞게 수열 변환하기 3
    /*
     * 문제 설명
     *   정수 배열 arr와 자연수 k가 주어집니다.
     *   만약 k가 홀수라면 arr의 모든 원소에 k를 곱하고, 
     *   k가 짝수라면 arr의 모든 원소에 k를 더합니다.
     *   이러한 변환을 마친 후의 arr를 return 하는 solution 함수를 완성해 주세요.
     *   
     *
     *
     *제한사항
     *     1 ≤ arr의 길이 ≤ 1,000,000
     *     1 ≤ arr의 원소의 값 ≤ 100
     *     1 ≤ k ≤ 100
     *      
     *      
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class 조건에_맞게_수열_변환하기_3
    {
        static public int[] solution(int[] arr, int k)
        {
            int[] answer = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (k % 2 == 0)
                    answer[i] = arr[i] + k;
                else
                    answer[i] = arr[i] * k;
            }


            return answer;
        }
    }
}
