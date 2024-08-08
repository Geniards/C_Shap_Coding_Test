using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 종이 자르기
    /*
     * 문제 설명
     *    머쓱이는 큰 종이를 1 x 1 크기로 자르려고 합니다. 
     *    예를 들어 2 x 2 크기의 종이를 1 x 1 크기로 자르려면 
     *    최소 가위질 세 번이 필요합니다.
     *    
     *    정수 M, N이 매개변수로 주어질 때, M x N 크기의 종이를 
     *    최소로 가위질 해야하는 횟수를 return 하도록 solution 함수를 완성해보세요.
     *
     *
     *제한사항
     *      0 < M, N < 100
     *      종이를 겹쳐서 자를 수 없습니다.
     *      
     *      
     * 문제해결
     *      그냥 풀렸다...
     *      
     *      
     */
    #endregion
    public class 종이_자르기
    {
        static public int solution(int M, int N)
        {
            int answer = 0;

            M *= N;

            answer = M - 1;

            return answer;
        }
    }
}
