using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 배열의 길이에 따라 다른 연산하기
    /*
     * 문제 설명
     *    정수 배열 arr과 정수 n이 매개변수로 주어집니다. 
     *    arr의 길이가 홀수라면 arr의 모든 짝수 인덱스 위치에 n을 더한 배열을, 
     *    arr의 길이가 짝수라면 arr의 모든 홀수 인덱스 위치에 n을 더한 배열을 
     *    return 하는 solution 함수를 작성해 주세요.
     *
     *
     *제한사항
     *      1 ≤ arr의 길이 ≤ 1,000
     *      1 ≤ arr의 원소 ≤ 1,000
     *      1 ≤ n ≤ 1,000
     *      
     *      
     * 문제해결
     *      list에 문자열 길이를 담아두고 그것을 비교해서 파악
     *      gropby, orderbydescending, first 와우......
     *      
     *      
     */
    #endregion
    public class 배열의_길이에_따라_다른_연산하기
    {
        static public int[] solution(int[] arr, int n)
        {
            int[] answer = new int[arr.Length];

            if (arr.Length % 2 == 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 != 0)
                        answer[i] = arr[i] + n;
                    else
                        answer[i] = arr[i];
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i % 2 == 0)
                        answer[i] = arr[i] + n;
                    else
                        answer[i] = arr[i];
                }
            }
            return answer;
        }
    }
}
