using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv1._나머지가_1이_되는_수_찾기
{
    /*
   * 나머지가 1이 되는 수 찾기(87389)
   * 
   * 문제 설명
   *      자연수 n이 매개변수로 주어집니다. n을 x로 나눈 나머지가 1이 되도록 하는 
   *      가장 작은 자연수 x를 return 하도록 solution 함수를 완성해주세요. 
   *      답이 항상 존재함은 증명될 수 있습니다.
   *      
   * 제한 조건
   *      3 ≤ n ≤ 1,000,000
   *            
   * 문제해결
   *      제한조건을 어디다가 적용할지를 잘 파악하자
   */
    public class Lv1_나머지가_1이_되는_수_찾기
    {
        static public int solution(int n)
        {
            int answer = 0;

            for (int i = 2; i < 1000000; i++)
            {
                if (n % i == 1)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
    }
}
