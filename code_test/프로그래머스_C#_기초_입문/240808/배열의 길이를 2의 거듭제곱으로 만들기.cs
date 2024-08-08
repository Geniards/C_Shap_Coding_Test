using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 배열의 길이를 2의 거듭제곱으로 만들기

    /*
     * 문제 설명
     *     정수 배열 arr이 매개변수로 주어집니다. 
     *     arr의 길이가 2의 정수 거듭제곱이 되도록 arr 뒤에 정수 0을 추가하려고 합니다. 
     *     arr에 최소한의 개수로 0을 추가한 배열을 return 하는 solution 함수를 작성해 주세요.
     *      
     * 제한사항
     *      1 ≤ arr의 길이 ≤ 1,000
     *      1 ≤ arr의 원소 ≤ 1,000
     *      
     *      
     * 문제해결
     *      2의 거듭제곱으로 배열의 길이가 커져나가야 한다.
     *      
     *      
     */
    #endregion
    public class 배열의_길이를_2의_거듭제곱으로_만들기
    {
        static public int[] solution(int[] arr)
        {
            int[] answer = new int[arr.Length];

            // 0으로 시작하면 2부터 시작이된다.
            int temp = 1;

            while (temp < arr.Length)
            {
                temp *= 2;
            }

            answer = new int[temp];

            for (int i = 0; i < arr.Length; i++)
            {
                answer[i] = arr[i];
            }

            foreach (int i in answer)
                Console.WriteLine(i);

            return answer;
        }
    }
}
