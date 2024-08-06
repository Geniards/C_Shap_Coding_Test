using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240806
{
    #region 무작위로 K개의 수 뽑기

    /*
     * 문제 설명
     *      랜덤으로 서로 다른 k개의 수를 저장한 배열을 만드려고 합니다. 
     *      적절한 방법이 떠오르지 않기 때문에 일정한 범위 내에서 무작위로 수를 뽑은 후, 
     *      지금까지 나온적이 없는 수이면 배열 맨 뒤에 추가하는 방식으로 만들기로 합니다.
     *      
     *      이미 어떤 수가 무작위로 주어질지 알고 있다고 가정하고, 
     *      실제 만들어질 길이 k의 배열을 예상해봅시다.
     *      정수 배열 arr가 주어집니다. 
     *      
     *      문제에서의 무작위의 수는 arr에 저장된 순서대로 주어질 예정이라고 했을 때, 
     *      완성될 배열을 return 하는 solution 함수를 완성해 주세요.
     *      
     *      단, 완성될 배열의 길이가 k보다 작으면 
     *      나머지 값을 전부 -1로 채워서 return 합니다.
     *      
     *      
     * 제한사항
     *      1 ≤ arr의 길이 ≤ 1,000,000
     *      arr의 원소는 0 또는 1 입니다.
     *      
     *      
     * 문제해결
     *      contains으로 해결.
     */
    #endregion
    public class 무작위로_K개의_수_뽑기
    {
        static public int[] solution(int[] arr, int k)
        {
            int[] answer = new int[] { };
            int temp = 1;
            List<int> list = new List<int>();
            list.Add(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                if (temp >= k)
                    break;
                if (!list.Contains(arr[i]))
                {
                    list.Add(arr[i]);
                    temp++;
                }
            }

            while (list.Count < k)
            {
                list.Add(-1);
            }

            foreach (int i in list)
                Console.WriteLine(i);

            return answer = list.ToArray();
        }
    }
}
