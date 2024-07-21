using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기
{
    internal class 주사위의_개수____에라토스테네스의_체_구현
    {
        #region 주사위의 개수____에라토스테네스의 체 구현
        //static public int solution(int n)
        //{
        //    int answer = 0;
        //    bool[] isPrime = new bool[n+1];
        //    Array.Fill(isPrime, true);

        //    // 0과 1은 무시
        //    isPrime[0] = isPrime[1] = false;

        //    //2의 배수부터 시작
        //    for (int i = 2; i * i <= n; i++)
        //    {
        //        if (isPrime[i])
        //        {
        //            // 2^2 -> 3^3 -> 5^5 ... 배수로 체크하면서 true인 부분들을 체크
        //            for (int j = i * i; j <= n; j += i)
        //            {
        //                isPrime[j] = false;
        //            }
        //        }
        //    }

        //    //true인 부분이 소수이다.
        //    for(int i = 2; i<=n;i++)
        //        if (!isPrime[i]) answer++;

        //    return answer;
        //}

        //static void Main(string[] args)
        //{
        //    int a = 10;

        //    Console.WriteLine($"{solution(a)}");

        //}
        #endregion
    }
}
