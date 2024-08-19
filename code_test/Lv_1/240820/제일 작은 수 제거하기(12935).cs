using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240820
{
    #region 제일 작은 수 제거하기(12935)
    /*
 * 문제 설명
 *   정수를 저장한 배열, arr 에서 가장 작은 수를 제거한 배열을 리턴하는 함수, 
 *   solution을 완성해주세요. 
 *   단, 리턴하려는 배열이 빈 배열인 경우엔 배열에 -1을 채워 리턴하세요. 
 *   예를들어 arr이 [4,3,2,1]인 경우는 [4,3,2]를 리턴 하고, [10]면 [-1]을 리턴 합니다.
 *   
 * 제한사항
 *   arr은 길이 1 이상인 배열입니다.
 *   인덱스 i, j에 대해 i ≠ j이면 arr[i] ≠ arr[j] 입니다.
 *
 * 문제해결
 *      다른 접근 방식을 생각해보자
 *      
 *      
 */
    #endregion
    public class 제일_작은_수_제거하기_12935_
    {
        static public int[] solution(int[] arr)
        {
            int[] answer = new int[arr.Length - 1];
            List<int> list = new List<int>();

            int temp = arr.Min();

            for (int i = 0; i < arr.Length; i++)
            {
                if (answer.Length == 0)
                    return answer = new int[1] { -1 };

                if (temp != arr[i])
                {
                    list.Add(arr[i]);
                }
            }

            return answer = list.ToArray();
        }
    }
}
