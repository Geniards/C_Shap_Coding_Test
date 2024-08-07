using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기._240807
{
    /*
    * 문제 설명
    *      정수 n을 기준으로 n과 가까운 수부터 정렬하려고 합니다. 
    *      이때 n으로부터의 거리가 같다면 더 큰 수를 앞에 오도록 배치합니다. 
    *      정수가 담긴 배열 numlist와 정수 n이 주어질 때 
    *      numlist의 원소를 n으로부터 가까운 순서대로 정렬한 배열을 return하도록 
    *      solution 함수를 완성해주세요.
    *      
    * 제한사항
    *      1 ≤ n ≤ 10,000
    *      1 ≤ numlist의 원소 ≤ 10,000
    *      1 ≤ numlist의 길이 ≤ 100
    *      numlist는 중복된 원소를 갖지 않습니다.
    *      
    *      
    * 문제해결
    *      (Linq를 더 찾아보도록 하자...)
    *      배열원소에 각 기준 값을 뺀 값으로 (numlist[i] - n의 절대값을 기준)
    *       1) 각 원소와 기준 숫자 n 사이의 절대값 오름차순 == OrderBy()로 1차로 정렬함
    *       2) 같은 값이 존재시 내림차순으로 == ThenByDescending()으로 1차로 정렬한 값 중 같은 경우를 내림차순으로 정렬
    *                                          ThenBy() = 1차정렬 이후 같은 값에 대한 2차 정렬 오름차순으로
    */
    public class 특이한_정렬
    {
        static public int[] solution(int[] numlist, int n)
        {
            int[] answer = new int[numlist.Length];


            answer = numlist.OrderBy(x => Math.Abs(x - n)).ThenByDescending(x => x).ToArray();

            foreach (int x in answer)
                Console.WriteLine(x);

            return answer;
        }
    }
}
