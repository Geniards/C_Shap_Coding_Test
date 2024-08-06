using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기._240806
{
    #region 겹치는 선분의 길이

    /*
     * 문제 설명
     *      선분 3개가 평행하게 놓여 있습니다. 
     *      세 선분의 시작과 끝 좌표가 
     *      [[start, end], [start, end], [start, end]] 형태로 들어있는 
     *      2차원 배열 lines가 매개변수로 주어질 때, 
     *      두 개 이상의 선분이 겹치는 부분의 길이를 
     *      return 하도록 solution 함수를 완성해보세요.
     *      
     *      lines가 [[0, 2], [-3, -1], [-2, 1]]일 때 그림으로 나타내면 다음과 같습니다.
     *      선분이 두 개 이상 겹친 곳은 [-2, -1], [0, 1]로 길이 2만큼 겹쳐있습니다.
     *      
     * 제한사항
     *      lines의 길이 = 3
     *      lines의 원소의 길이 = 2
     *      모든 선분은 길이가 1 이상입니다.
     *      lines의 원소는 [a, b] 형태이며, a, b는 각각 선분의 양 끝점 입니다.
     *      -100 ≤ a < b ≤ 100
     *      
     *      
     * 문제해결
     *      배열에서 시작지점과 끝지점의 최소값과 최댓값을 구하고 
     *      해당 범위안에서 겹치는 부분이 있는지 파악하기.
     */
    #endregion
    public class 겹치는_선분의_길이
    {
        static public int solution(int[,] lines)
        {
            int answer = 0;
            int min = lines[0, 0];
            int max = lines[0, 1];

            for (int i = 1; i < lines.GetLength(0); i++)
            {
                for (int j = 0; j < lines.GetLength(1); j++)
                {
                    if (min > lines[i, j])
                        min = lines[i, j];   // 가장 작은 값 == 왼쪽 끝
                    if (max < lines[i, j])  // 가장 큰 값 == 가장 오른쪽
                        max = lines[i, j];
                }
            }

            for (int i = min; i < max; i++)
            {
                // 새로 시작할때마다 초기화
                int temp = 0;

                for (int j = 0; j < lines.GetLength(0); j++)
                {
                    // i, i+1 == 1의 길이를 가진 값
                    // 해당 범위 안에 들어있으면 temp증가
                    if (lines[j, 0] <= i && i + 1 <= lines[j, 1])
                        temp++;
                }

                // 두개 이상이면 겹쳐진 것
                // 세번 겹칠 수 있기에 >=로 표현
                if (temp >= 2)
                    answer++;
            }


            return answer;
        }
    }
}
