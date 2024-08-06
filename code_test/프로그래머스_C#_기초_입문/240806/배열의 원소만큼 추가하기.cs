using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240806
{
    #region 배열의 원소만큼 추가하기
    /*
     * 문제 설명
     *      아무 원소도 들어있지 않은 빈 배열 X가 있습니다. 
     *      양의 정수 배열 arr가 매개변수로 주어질 때, 
     *      arr의 앞에서부터 차례대로 원소를 보면서 
     *      원소가 a라면 X의 맨 뒤에 a를 a번 추가하는 일을 
     *      반복한 뒤의 배열 X를 return 하는 solution 함수를 작성해 주세요.
     *      
     *      
     * 제한사항
     *      1 ≤ arr의 길이 ≤ 100
     *      1 ≤ arr의 원소 ≤ 100
     *      
     *      
     * 문제해결
     *      
     */
    #endregion

    public class 배열의_원소만큼_추가하기
    {
        static public int[] solution(int[] arr)
        {
            int[] answer = new int[] { };
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                while (temp < arr[i])
                {
                    list.Add(arr[i]);
                    temp++;
                }
            }

            foreach (var i in list)
                Console.Write($"{i} ");

            return answer = list.ToArray();
        }
    }
}
