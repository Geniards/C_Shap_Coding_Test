﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv1._약수의_합
{
    /*
    * 약수의_합(12928)
    * 
    * 문제 설명
    *      정수 n을 입력받아 n의 약수를 모두 더한 값을 리턴하는 함수, 
    *      solution을 완성해주세요.
    *      
    * 제한 조건
    *      n은 0 이상 3000이하인 정수입니다.
    *            
    * 문제해결
    *      -
    */
    public class Program
    {
        static public int solution(int n)
        {
            int answer = 0;
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                    answer += n / i;
                i++;
            }

            return answer;
        }
    }
}
