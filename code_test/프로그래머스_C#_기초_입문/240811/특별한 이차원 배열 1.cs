using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240811
{
    #region 특별한 이차원 배열 1
    /*
     * 문제 설명
     *   정수 n이 매개변수로 주어질 때, 
     *   다음과 같은 n × n 크기의 이차원 배열 arr를 return 하는 solution 함수를 작성해 주세요.
     *   arr[i][j] (0 ≤ i, j < n)의 값은 i = j라면 1, 아니라면 0입니다.
     *   
     *
     *
     *제한사항
     *     1 ≤ n ≤ 100
     *      
     *      
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class 특별한_이차원_배열_1
    {
        static public int[,] solution(int n)
        {
            int[,] answer = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        answer[i, j] = 1;
                    else
                        answer[i, j] = 0;
                }
            }
            return answer;
        }
    }
}
