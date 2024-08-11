using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240811
{
    #region 그림 확대
    /*
     * 문제 설명
     *   직사각형 형태의 그림 파일이 있고, 
     *   이 그림 파일은 1 × 1 크기의 정사각형 크기의 픽셀로 이루어져 있습니다. 
     *   이 그림 파일을 나타낸 문자열 배열 picture과 정수 k가 매개변수로 주어질 때, 
     *   이 그림 파일을 가로 세로로 k배 늘린 그림 파일을 나타내도록 문자열 배열을 
     *   return 하는 solution 함수를 작성해 주세요.
     *   
     *
     *
     *제한사항
     *     1 ≤ picture의 길이 ≤ 20
     *     1 ≤ picture의 원소의 길이 ≤ 20
     *     모든 picture의 원소의 길이는 같습니다.
     *     picture의 원소는 '.'과 'x'로 이루어져 있습니다.
     *     1 ≤ k ≤ 10
     *      
     *      
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class 그림_확대
    {
        static public string[] solution(string[] picture, int k)
        {
            string[] answer = new string[picture.Length * k];
            StringBuilder sb = new StringBuilder();
            int temp = 0;
            int temp2 = 0;

            for (int i = 0; i < picture.Length; i++)
            {
                for (int j = 0; j < picture[i].Length;)
                {
                    while (temp != k)
                    {
                        sb.Append(picture[i][j]);
                        temp++;
                    }

                    j++;
                    temp = 0;
                }

                while (temp != k)
                {
                    answer[temp2] = sb.ToString();
                    temp++;
                    temp2++;
                }
                temp = 0;
                sb.Clear();
            }

            foreach (var v in answer)
            {
                Console.WriteLine(v);
            }

            return answer;
        }
    }
}
