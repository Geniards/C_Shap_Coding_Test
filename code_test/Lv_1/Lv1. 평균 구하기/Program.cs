﻿namespace Lv1._평균_구하기
{
    /*
        * 평균_구하기(12944)
        * 
        * 문제 설명
        *      정수를 담고 있는 배열 arr의 평균값을 return하는 함수,
        *      solution을 완성해보세요.
        *      
        * 제한 조건
        *      arr은 길이 1 이상, 100 이하인 배열입니다.
        *      arr의 원소는 -10,000 이상 10,000 이하인 정수입니다.
        *          
        *      
        * 문제해결
        *      배열로 주어졌기에 Linq의 averrage를 써도 될듯하다.
        */
    public class Program
    {
        static public double solution(int[] arr)
        {
            double answer = 0;

            foreach (int i in arr) 
                answer += i;

            answer /= arr.Length;

            return answer;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            Console.WriteLine(solution(arr));
        }
    }
}
