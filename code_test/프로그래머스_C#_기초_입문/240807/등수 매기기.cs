using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240807
{
    #region 등수 매기기

    /*
     * 문제 설명
     *      영어 점수와 수학 점수의 평균 점수를 기준으로 학생들의 등수를 매기려고 합니다. 
     *      영어 점수와 수학 점수를 담은 2차원 정수 배열 score가 주어질 때, 
     *      영어 점수와 수학 점수의 평균을 기준으로 매긴 등수를 담은 배열을 
     *      return하도록 solution 함수를 완성해주세요.
     *      
     * 제한사항
     *      0 ≤ score[0], score[1] ≤ 100
     *      1 ≤ score의 길이 ≤ 10
     *      score의 원소 길이는 2입니다.
     *      score는 중복된 원소를 갖지 않습니다.
     *      
     *      
     * 문제해결
     *      C#으로 안풀릴때는 C++식으로 풀고 변환 해주기
     *      평균으로 인한 소수점 발생시 그냥 총합으로 비교도 가능
     *      
     *      
     */
    #endregion
    public class 등수_매기기
    {
        static public int[] solution(int[,] score)
        {
            int[] answer = new int[score.GetLength(0)];
            #region 다른사람 풀이
            //Array.Fill(answer, 1);

            //for (int i = 0; i < score.GetLength(0); i++)
            //{
            //    for (int j = 0; j < score.GetLength(0); j++)
            //    {
            //        if (score[i, 0] + score[i, 1] > score[j, 0] + score[j, 1])
            //        {
            //            answer[j]++;
            //        }
            //    }
            //}
            #endregion

            #region C++식으로 풀었음
            //for (int i = 0; i < score.GetLength(0); i++)
            //{
            //    // 평균값 구하기
            //    float avg = (score[i, 0] + score[i, 1]) / 2.0f;
            //    // 첫번째로 구했으니 1등
            //    int index = 1;

            //    for (int j = 0; j < score.GetLength(0); j++)
            //    {
            //        // 같은 값은 넘겨주고
            //        if (i == j) continue;

            //        // 비교할 평균값 구하기
            //        float nextAvg = (score[j, 0] + score[j, 1]) / 2.0f;


            //        if (nextAvg > avg)
            //        {
            //            index++;
            //        }
            //    }

            //    answer[i] = index;
            //}

            //return answer;
            #endregion

            #region C#
            List<int> result = new List<int>();
            List<int> result2 = new List<int>();

            for (int i = 0; i < score.GetLength(0); i++)
            {
                // 소수점이 생길 가능성으로 평균을 안매기고 총합으로 비교
                answer[i] = (score[i, 0] + score[i, 1]);
                result.Add(score[i, 0] + score[i, 1]);
            }

            result.Sort();
            result.Reverse();

            foreach (int i in answer)
            {
                result2.Add(result.IndexOf(i) + 1);
            }

            foreach (int i in result2)
                Console.WriteLine(i);

            return answer = result2.ToArray();
            #endregion
        }
    }
}
