﻿namespace Lv1._정수_제곱근_판별
{
    /*
   * 정수_제곱근_판별(12934)
   * 
   * 문제 설명
   *      임의의 양의 정수 n에 대해, n이 어떤 양의 정수 x의 제곱인지 아닌지 판단하려 합니다.
   *      n이 양의 정수 x의 제곱이라면 x+1의 제곱을 리턴하고, 
   *      n이 양의 정수 x의 제곱이 아니라면 -1을 리턴하는 함수를 완성하세요.
   *      
   * 제한 조건
   *      n은 1이상, 50000000000000 이하인 양의 정수입니다.
   *          
   *      
   *      
   * 문제해결
   *      Math의 Sqrt(루트)와 Pow(제곱)을 활용함.
   */
    public class Program
    {
        static public long solution(long n)
        {
            long answer = 0;

            if (n % Math.Sqrt(n) == 0)
            {
                answer = (long)Math.Pow(Math.Sqrt(n) + 1, 2);
            }
            else
                answer = -1;

            return answer;
        }

        //static void Main(string[] args)
        //{
        //    int n = 121;

        //    Console.WriteLine(solution(n));
        //}
    }
}
