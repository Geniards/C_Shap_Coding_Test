using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace code_test
{
    #region 정수를 나선형으로 배치하기
    /*
     * 문제 설명
     *   양의 정수 n이 매개변수로 주어집니다. 
     *   n × n 배열에 1부터 n2 까지 정수를 
     *   인덱스 [0][0]부터 시계방향 나선형으로 배치한 
     *   이차원 배열을 return 하는 solution 함수를 작성해 주세요.
     *   
     *
     *
     *제한사항
     *     1 ≤ n ≤ 30
     *      
     *      
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion

    public class Program
    {
        static public int[,] solution(int n)
        {
            int[,] answer = new int[,] { { } };
            return answer;
        }
        static void Main(string[] args)
        {

            int a = 4;
            int b = 3;
            int c = 2;

            Console.WriteLine(solution(a));

        }
    }
}
