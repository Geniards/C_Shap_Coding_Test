using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240807
{
    #region 옹알이 (1)

    /*
     * 문제 설명
     *      머쓱이는 태어난 지 6개월 된 조카를 돌보고 있습니다. 
     *      조카는 아직 "aya", "ye", "woo", "ma" 
     *      네 가지 발음을 최대 한 번씩 사용해 조합한(이어 붙인) 발음밖에 하지 못합니다. 
     *      문자열 배열 babbling이 매개변수로 주어질 때, 
     *      머쓱이의 조카가 발음할 수 있는 단어의 개수를 return하도록 
     *      solution 함수를 완성해주세요.
     *      
     * 제한사항
     *      1 ≤ babbling의 길이 ≤ 100
     *      1 ≤ babbling[i]의 길이 ≤ 15
     *      
     *      babbling의 각 문자열에서 "aya", "ye", "woo", "ma"는 
     *      각각 최대 한 번씩만 등장합니다.
     *      
     *      즉, 각 문자열의 가능한 모든 부분 문자열 중에서 
     *      "aya", "ye", "woo", "ma"가 한 번씩만 등장합니다.
     *      
     *      문자열은 알파벳 소문자로만 이루어져 있습니다.
     *      
     *      
     * 문제해결
     *      Replace를 이용하여 풀이
     *      IsNullOrWhiteSpace()를 이용하면 빈문자열을 체크한다.
     *      
     *      
     */
    #endregion
    public class 옹알이__1_
    {
        static public int solution(string[] babbling)
        {
            #region 다른사람 풀이
            //int answer = 0;
            //string[] str = { "aya", "ye", "woo", "ma" };

            //for (int i = 0; i < babbling.Length; i++)
            //{
            //    int temp = 0;

            //    while (temp < str.Length)
            //    {
            //        babbling[i] = babbling[i].Replace(str[temp], "");
            //        temp++;
            //    }

            //    if (string.IsNullOrEmpty(babbling[i]))
            //        answer++;
            //}
            //return answer;
            #endregion

            #region 내풀이...
            int answer = 0;
            string[] str = { "aya", "ye", "woo", "ma" };

            for (int i = 0; i < babbling.Length; i++)
            {
                int temp = 0;

                while (temp < str.Length)
                {
                    babbling[i] = babbling[i].Replace(str[temp], "");
                    temp++;
                }

                if (string.IsNullOrEmpty(babbling[i]))
                    answer++;
            }
            foreach (var i in babbling)
            {
                if (" " == i || "  " == i || "   " == i || "    " == i)
                    answer++;
            }

            return answer;
            #endregion

        }
    }
}
