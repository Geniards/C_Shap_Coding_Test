using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240807
{
    #region 유한소수 판별하기

    /*
     * 문제 설명
     *      소수점 아래 숫자가 계속되지 않고 유한개인 소수를 유한소수라고 합니다. 
     *      분수를 소수로 고칠 때 유한소수로 나타낼 수 있는 분수인지 판별하려고 합니다. 
     *      유한소수가 되기 위한 분수의 조건은 다음과 같습니다.
     *      
     *      기약분수로 나타내었을 때, 분모의 소인수가 2와 5만 존재해야 합니다.
     *      두 정수 a와 b가 매개변수로 주어질 때, a/b가 유한소수이면 1을, 
     *      무한소수라면 2를 return하도록 solution 함수를 완성해주세요.
     *      
     * 제한사항
     *      a, b는 정수
     *      0 < a ≤ 1,000
     *      0 < b ≤ 1,000
     *      
     *      
     * 문제해결
     *      문제대로 최대공약수를 구하고 기약분수로 만들어서 2||5로 소인수분해 한다.
     */
    #endregion
    public class 유한소수_판별하기
    {
        static int gcd(int a, int b)
        {
            int num1;
            int num2;
            int temp;

            // 큰수를 찾아야한다.
            if (a < b)
            {
                num1 = a;
                num2 = b;
            }
            else
            {
                num1 = b;     // 8
                num2 = a;     // 10
            }

            // 여기가 핵심이다.
            // 분모는 0이면 안된다.
            while (num2 != 0)    // num1 > num2
            {
                //                  8    10                나머지     
                temp = num1 % num2;  // 8          2      0
                num1 = num2;         // 10         10     2
                num2 = temp;         // 8          2      0
            }

            return num1;
        }

        static public int solution(int a, int b)
        {
            int answer = 0;

            int num = gcd(a, b);

            // 기약분수 = 분모 / 최대공약수
            b /= num;

            // 2 || 5로 소인수분해
            while (b % 2 == 0)
                b /= 2;

            while (b % 5 == 0)
                b /= 5;


            if (b == 1)
                answer = 1;
            else
                answer = 2;

            return answer;
        }
    }
}
