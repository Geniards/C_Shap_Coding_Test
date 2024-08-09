using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기._240809
{
    #region 두 수의 합(string)
    /*
     * 문제 설명
     *    정수로 이루어진 문자열 n_str이 주어질 때, 
     *    n_str의 가장 왼쪽에 처음으로 등장하는 0들을 뗀 문자열을 
     *    return하도록 solution 함수를 완성해주세요.
     *
     *
     *제한사항
     *      2 ≤ n_str ≤ 10
     *      n_str이 "0"으로만 이루어진 경우는 없습니다.
     *      
     *      
     * 문제해결
     *      뒤에서 하나씩 더해서 풀어나가야한다.
     *      처음에는 몰랐다가 범위가 터져나가는 것을 보다가 생각남.
     *      
     *      
     */
    #endregion
    public class 두_수의_합_string_
    {
        static public string solution(string a, string b)
        {
            string answer = "";

            // 전체 길이를 똑같이 채우고 비교한다.
            // 자료형의 범위를 넘어서는 경우가 발생하기에
            // 뒤에서부터 하나씩 더해나간다.
            int maxLength = Math.Max(a.Length, b.Length);

            // 앞에 부분을 0으로 채우기
            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');

            //stringbuilder를 통해서 하나씩 넣기
            StringBuilder sb = new StringBuilder();
            int Num10 = 0;  // 10의 자리수

            for (int i = maxLength - 1; i >= 0; i--)
            {
                // int.Parse()보다 속도측에서 빠르다.
                int A = a[i] - '0';
                int B = b[i] - '0';
                int sum = A + B + Num10;

                // 10의 자리수 받아오기
                Num10 = sum / 10;
                // 맨 앞에 삽입
                sb.Insert(0, sum % 10);
            }

            // 계산이 끝나고 숫자가 남아있는 경우
            if (Num10 > 0)
                sb.Insert(0, Num10);

            return answer = sb.ToString();
        }
    }
}
