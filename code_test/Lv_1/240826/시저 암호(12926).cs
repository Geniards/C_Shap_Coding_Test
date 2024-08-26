using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240826
{
    #region 시저 암호(12926)

    /*
     * 문제 설명
     *   어떤 문장의 각 알파벳을 일정한 거리만큼 밀어서 
     *   다른 알파벳으로 바꾸는 암호화 방식을 시저 암호라고 합니다. 
     *   
     *   예를 들어 "AB"는 1만큼 밀면 "BC"가 되고, 3만큼 밀면 "DE"가 됩니다. 
     *   "z"는 1만큼 밀면 "a"가 됩니다. 
     *   문자열 s와 거리 n을 입력받아 s를 n만큼 민 암호문을 만드는 함수, solution을 완성해 보세요.
     *   
     *   
     *   
     * 제한사항
     *   공백은 아무리 밀어도 공백입니다.
     *   s는 알파벳 소문자, 대문자, 공백으로만 이루어져 있습니다.
     *   s의 길이는 8000이하입니다.
     *   n은 1 이상, 25이하인 자연수입니다.
     *
     * 문제해결
     *      조건을 간단하게 달도록 하자
     *      
     *      
     */
    #endregion
    public class 시저_암호_12926_
    {
        public string solution(string s, int n)
        {
            // 65-90 A-Z
            // 97-122 a-z
            string answer = "";

            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if ((int)chars[i] == 122)
                {
                    chars[i] = (char)(96 + n);
                }
                else if ((int)chars[i] < 122 && (int)chars[i] > 96)
                {
                    if ((int)(chars[i] + n) > 122)
                    {
                        chars[i] = ((char)(96 + (chars[i] + n - 122)));
                    }
                    else
                        chars[i] = (char)(chars[i] + n);
                }
                else if ((int)chars[i] == 90)
                {
                    chars[i] = ((char)(64 + n));
                }
                else if ((int)chars[i] < 90 && (int)chars[i] > 64)
                {
                    if ((int)(chars[i] + n) > 90)
                    {
                        chars[i] = ((char)(64 + (chars[i] + n - 90)));
                    }
                    else
                        chars[i] = (char)(chars[i] + n);
                }

            }

            return answer = new string(chars);
        }
    }
}
