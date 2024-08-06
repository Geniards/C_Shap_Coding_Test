using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기._240806
{
    /*
     * 문제 설명
     *      점 네 개의 좌표를 담은 이차원 배열  dots가 다음과 같이 매개변수로 주어집니다.
     *      [[x1, y1], [x2, y2], [x3, y3], [x4, y4]]
     *      주어진 네 개의 점을 두 개씩 이었을 때, 
     *      두 직선이 평행이 되는 경우가 있으면 1을 없으면 0을 return 하도록 
     *      solution 함수를 완성해보세요.
     *      
     *      
     * 제한사항
     *      dots의 길이 = 4
     *      dots의 원소는 [x, y] 형태이며 x, y는 정수입니다.
     *      0 ≤ x, y ≤ 100
     *      서로 다른 두개 이상의 점이 겹치는 경우는 없습니다.
     *      두 직선이 겹치는 경우(일치하는 경우)에도 1을 return 해주세요.
     *      임의의 두 점을 이은 직선이 x축 또는 y축과 평행한 경우는 주어지지 않습니다.
     *      
     *      
     * 문제해결
     *      두점의 기울기 구하기 공식( (y2-y1) / (x2-x1) ) + 소수점 처리
     */
    public class 평행
    {
        static public int solution(int[,] dots)
        {
            int answer = 0;

            if ((double)Math.Abs(dots[0, 1] - dots[1, 1]) / (double)Math.Abs(dots[0, 0] - dots[1, 0]) == (double)Math.Abs(dots[2, 1] - dots[3, 1]) / (double)Math.Abs(dots[2, 0] - dots[3, 0])
                ||
                (double)Math.Abs(dots[0, 1] - dots[2, 1]) / (double)Math.Abs(dots[0, 0] - dots[2, 0]) == (double)Math.Abs(dots[1, 1] - dots[3, 1]) / (double)Math.Abs(dots[1, 0] - dots[3, 0])
                ||
                (double)Math.Abs(dots[0, 1] - dots[3, 1]) / (double)Math.Abs(dots[0, 0] - dots[3, 0]) == (double)Math.Abs(dots[1, 1] - dots[2, 1]) / (double)Math.Abs(dots[1, 0] - dots[2, 0]))
                answer = 1;

            return answer;

            #region Distinct() 배열에서 중복을 지워주는 것

            //List<float> slopes = new List<float>();
            //int length = dots.GetLength(0);
            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = i + 1; j < length; j++)
            //    {
            //        slopes.Add((dots[i, 1] - dots[j, 1]) / (float)(dots[i, 0] - dots[j, 0]));
            //    }
            //}

            //// 기울기가 같은 것이 존재하면 전체 갯수(4C2) 6개 보다 작다.(중복을 제거했기에)
            //return slopes.Distinct().Count() == length * (length - 1) / 2 ? 0 : 1;


            #endregion
        }
    }
}
