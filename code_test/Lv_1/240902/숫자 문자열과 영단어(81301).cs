﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240902
{
    #region 숫자 문자열과 영단어(81301)

    /*
     * 문제 설명
     *      네오와 프로도가 숫자놀이를 하고 있습니다. 
     *      네오가 프로도에게 숫자를 건넬 때 일부 자릿수를 영단어로 바꾼 카드를 건네주면 
     *      프로도는 원래 숫자를 찾는 게임입니다.
     *      다음은 숫자의 일부 자릿수를 영단어로 바꾸는 예시입니다.
     *      
     *      1478 → "one4seveneight"
     *      234567 → "23four5six7"
     *      10203 → "1zerotwozero3"
     *      
     *      이렇게 숫자의 일부 자릿수가 영단어로 바뀌어졌거나, 
     *      혹은 바뀌지 않고 그대로인 문자열 s가 매개변수로 주어집니다. 
     *      s가 의미하는 원래 숫자를 return 하도록 solution 함수를 완성해주세요.
     *   
     *   
     *   
     * 제한사항
     *   1 ≤ s의 길이 ≤ 50
     *   s가 "zero" 또는 "0"으로 시작하는 경우는 주어지지 않습니다.
     *   return 값이 1 이상 2,000,000,000 이하의 정수가 되는 올바른 입력만 s로 주어집니다.
     *
     *
     *
     * 문제해결
     *      Dictionery와 Replace를 사용하여 비교해서 구함
     * 
     * 
     *      
     *      
     */
    #endregion
    public class 숫자_문자열과_영단어_81301_
    {
        static public int solution(string s)
        {
            int answer = 0;

            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            for (int i = 0; i < 10; i++)
            {
                keyValuePairs.Add(strings[i], i);
            }

            for (int i = 0; i < 10; i++)
            {
                s = s.Replace(strings[i], keyValuePairs[strings[i]].ToString());
            }

            return answer = int.Parse(s);
        }
    }
}
