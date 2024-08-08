using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 문자열 묶기
    /*
     * 문제 설명
     *    문자열 배열 strArr이 주어집니다. 
     *    strArr의 원소들을 길이가 같은 문자열들끼리 그룹으로 묶었을 때 
     *    가장 개수가 많은 그룹의 크기를 return 하는 solution 함수를 완성해 주세요.
     *
     *
     *제한사항
     *      1 ≤ strArr의 길이 ≤ 100,000
     *      1 ≤ strArr의 원소의 길이 ≤ 30
     *      strArr의 원소들은 알파벳 소문자로 이루어진 문자열입니다.
     *      
     *      
     * 문제해결
     *      list에 문자열 길이를 담아두고 그것을 비교해서 파악
     *      gropby, orderbydescending, first 와우......
     *      
     *      
     */
    #endregion
    public class 문자열_묶기
    {
        static public int solution(string[] strArr)
        {
            #region 내 풀이
            int answer = 0;
            List<int> list = new List<int>();

            for (int i = 0; i < strArr.Length; i++)
            {
                list.Add(strArr[i].Length);
            }

            int[] temp = new int[list.Count];

            for (int i = 0; i < strArr.Length; i++)
            {
                // 0번 인덱스부터 시작 +1
                temp[list[i]] += 1;
            }

            answer = temp.Max();

            return answer;
            #endregion

            #region 다른사람 풀이
            //return strArr.GroupBy(g => g.Length)
            //         .OrderByDescending(o => o.Count())
            //         .First().Count();
            #endregion
        }
    }
}
