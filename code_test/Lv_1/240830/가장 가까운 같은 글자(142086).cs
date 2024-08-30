using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240830
{
    #region 가장 가까운 같은 글자(142086)

    /*
     * 문제 설명
     *   문자열 s가 주어졌을 때, s의 각 위치마다 자신보다 앞에 나왔으면서, 
     *   자신과 가장 가까운 곳에 있는 같은 글자가 어디 있는지 알고 싶습니다.
     *   예를 들어, s="banana"라고 할 때,  
     *   각 글자들을 왼쪽부터 오른쪽으로 읽어 나가면서 다음과 같이 진행할 수 있습니다.
     *   
     *   b는 처음 나왔기 때문에 자신의 앞에 같은 글자가 없습니다. 이는 -1로 표현합니다.
     *   a는 처음 나왔기 때문에 자신의 앞에 같은 글자가 없습니다. 이는 -1로 표현합니다.
     *   n은 처음 나왔기 때문에 자신의 앞에 같은 글자가 없습니다. 이는 -1로 표현합니다.
     *   a는 자신보다 두 칸 앞에 a가 있습니다. 이는 2로 표현합니다.
     *   n도 자신보다 두 칸 앞에 n이 있습니다. 이는 2로 표현합니다.
     *   a는 자신보다 두 칸, 네 칸 앞에 a가 있습니다. 이 중 가까운 것은 두 칸 앞이고, 
     *   이는 2로 표현합니다.
     *   따라서 최종 결과물은 [-1, -1, -1, 2, 2, 2]가 됩니다.
     *   
     *   문자열 s이 주어질 때, 위와 같이 정의된 연산을 수행하는 함수 solution을 완성해주세요.
     *   
     *   
     *   
     * 제한사항
     *   1 ≤ s의 길이 ≤ 10,000
     *      s은 영어 소문자로만 이루어져 있습니다.
     *
     * 문제해결
     *      뒤에서도 검색해 오는것을 막아야한다
     *      인덱스 - indexOf() = 결과
     *      
     *      
     */
    #endregion
    public class 가장_가까운_같은_글자_142086_
    {
        static public int[] solution(string s)
        {
            char[] chars = s.ToCharArray();
            StringBuilder sb = new StringBuilder();

            int[] answer = new int[chars.Length];
            sb.Append(chars[0]);
            answer[0] = -1;

            for (int i = 1; i < chars.Length; i++)
            {
                if (sb.ToString().LastIndexOf(chars[i]) == -1)
                    answer[i] = sb.ToString().LastIndexOf(chars[i]);
                else
                    answer[i] = i - sb.ToString().LastIndexOf(chars[i]);

                sb.Append(chars[i]);
            }

            foreach (var v in answer)
                Console.WriteLine(v);

            return answer;
        }
    }
}
