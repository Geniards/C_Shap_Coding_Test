using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240821
{
    #region 최대공약수와 최소공배수(12940)

    /*
     * 문제 설명
     *   두 수를 입력받아 두 수의 최대공약수와 최소공배수를 반환하는 함수, solution을 완성해 보세요. 
     *   배열의 맨 앞에 최대공약수, 그다음 최소공배수를 넣어 반환하면 됩니다. 
     *   예를 들어 두 수 3, 12의 최대공약수는 3, 
     *   최소공배수는 12이므로 solution(3, 12)는 [3, 12]를 반환해야 합니다.
     *   
     *   
     *   
     * 제한사항
     *   두 수는 1이상 1000000이하의 자연수입니다.
     *
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class 최대공약수와_최소공배수_12940_
    {
        static public int[] solution(int n, int m)
        {
            int[] answer = new int[2];

            int num1; //
            int num2; //
            int temp;

            if (n < m)
            {
                num1 = n;
                num2 = m;
            }
            else
            {
                num1 = m;     // 8
                num2 = n;     // 10
            }

            while (num2 != 0)    // num1 > num2
            {
                //                  8    10                나머지     
                temp = num1 % num2;  // 8          2      0
                num1 = num2;         // 10         10     2
                num2 = temp;         // 8          2      0
            }

            answer[0] = num1;
            answer[1] = n * m / num1;


            return answer;
        }
    }
}
