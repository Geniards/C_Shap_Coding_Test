using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_2._240819
{
    #region 최댓값과 최솟값(12939)

    /*
     * 문제 설명
     *   문자열 s에는 공백으로 구분된 숫자들이 저장되어 있습니다. 
     *   str에 나타나는 숫자 중 최소값과 최대값을 찾아 
     *   이를 "(최소값) (최대값)"형태의 문자열을 반환하는 함수, solution을 완성하세요.
     *   예를들어 s가 "1 2 3 4"라면 "1 4"를 리턴하고, 
     *   "-1 -2 -3 -4"라면 "-4 -1"을 리턴하면 됩니다.
     *   
     * 제한사항
     *   as에는 둘 이상의 정수가 공백으로 구분되어 있습니다.
     *
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class 최댓값과_최솟값_12939_
    {
        static public string solution(string s)
        {
            string answer = "";

            string[] inputs = s.Split(" ");
            List<int> list = new List<int>();

            foreach (string input in inputs)
            {
                list.Add(int.Parse(input));
            }

            answer = new string(list.Min().ToString() + " " + list.Max().ToString());

            return answer;
        }
    }
}
