using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기._240809
{
    #region 배열의 원소 삭제하기
    /*
     * 문제 설명
     *    정수 배열 arr과 delete_list가 있습니다. 
     *    arr의 원소 중 delete_list의 원소를 모두 삭제하고 
     *    남은 원소들은 기존의 arr에 있던 순서를 유지한 배열을
     *    return 하는 solution 함수를 작성해 주세요.
     *
     *
     *제한사항
     *      1 ≤ arr의 길이 ≤ 100
     *      1 ≤ arr의 원소 ≤ 1,000
     *      arr의 원소는 모두 서로 다릅니다.
     *      1 ≤ delete_list의 길이 ≤ 100
     *      1 ≤ delete_list의 원소 ≤ 1,000
     *      delete_list의 원소는 모두 서로 다릅니다.
     *      
     *      
     * 문제해결
     *      다른사람의 풀이를 보면 정말 간단하게 사용된듯하다...
     *      
     *      
     */
    #endregion
    public class 배열의_원소_삭제하기
    {
        static public int[] solution(int[] arr, int[] delete_list)
        {
            int[] answer = new int[] { };

            List<int> list = new List<int>();

            for (int i = 0; i < delete_list.Length; i++)
            {
                if (Array.IndexOf(arr, delete_list[i]) > -1)
                    arr[Array.IndexOf(arr, delete_list[i])] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    list.Add(arr[i]);
            }

            answer = list.ToArray();

            return answer;

            #region 다른사람풀이
            //1.
            //public int[] solution(int[] arr, int[] delete_list) => arr.Except(delete_list).ToArray();

            //2.
            //return arr.Where(w => !delete_list.Contains(w)).ToArray();

            #endregion
        }
    }
}
