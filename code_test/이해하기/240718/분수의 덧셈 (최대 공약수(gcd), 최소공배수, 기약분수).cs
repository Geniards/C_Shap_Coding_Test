using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기
{
    internal class Class4
    {
        #region 분수의 덧셈 (최대 공약수(gcd), 최소공배수, 기약분수)
        //static int gcd(int a, int b)
        //{
        //    int num1;
        //    int num2;
        //    int temp;

        //    if (a < b)
        //    {
        //        num1 = a;
        //        num2 = b;
        //    }
        //    else
        //    {
        //        num1 = b;
        //        num2 = a;
        //    }

        //    // 여기가 핵심이다.
        //    while(num2 != 0)    // num1 > num2
        //    {
        //        temp = num1 % num2;
        //        num1 = num2;
        //        num2 = temp;
        //    }

        //    return num1;
        //}


        //static int[] solution(int numer1, int denom1, int numer2, int denom2)
        //{
        //    int[] answer = new int[2];
        //    int GCD = gcd((numer1 * denom2 + numer2 * denom1), (denom1 * denom2));  
        //    // 분자, 분모의 최대 공약수를 구한 후 기약분수(분모가 1인 분수)를 만든다.
        //    //int LCD = (denom1 * denom2) / GCD;    //최소 공약수


        //    answer[0] = (numer1 * denom2 + numer2 * denom1) / GCD;
        //    answer[1] = (denom1 * denom2)/ GCD;

        //    return answer;
        //}

        //static void Main(string[] args)
        //{
        //    int a = 1;
        //    int b = 2;
        //    int c = 3;
        //    int d = 4;

        //    Console.WriteLine($"[{solution(a, b, c, d)[0]},{solution(a, b, c, d)[1]}]");

        //}
        #endregion
    }
}
