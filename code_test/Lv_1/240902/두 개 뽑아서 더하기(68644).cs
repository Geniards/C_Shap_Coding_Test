using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240902
{
    #region 두 개 뽑아서 더하기(68644)

    /*
     * 문제 설명
     *      정수 배열 numbers가 주어집니다. 
     *      numbers에서 서로 다른 인덱스에 있는 두 개의 수를 뽑아 
     *      더해서 만들 수 있는 모든 수를 배열에 오름차순으로 담아 return 하도록
     *      solution 함수를 완성해주세요.
     *   
     *   
     *   
     * 제한사항
     *   numbers의 길이는 2 이상 100 이하입니다.
     *   numbers의 모든 수는 0 이상 100 이하입니다.
     *
     *
     *
     * 문제해결
     *      HashSet을 사용해서 중복된 숫자를 제거 후 list에 옮겨서 정렬처리
     * 
     * 
     *      
     *      
     */
    #endregion
    public class 두_개_뽑아서_더하기_68644_
    {
        static public int[] solution(int[] numbers)
        {

            Array.Sort(numbers);

            HashSet<int> hasSet = new HashSet<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int sum = numbers[i] + numbers[j];
                    hasSet.Add(sum);
                }
            }
            int[] answer = new int[hasSet.Count];

            answer = hasSet.ToArray();

            Array.Sort(answer);

            return answer;
        }
    }
}
