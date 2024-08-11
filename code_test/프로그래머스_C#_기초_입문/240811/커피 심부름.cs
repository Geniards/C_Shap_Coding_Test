using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240811
{
    #region 커피 심부름
    /*
     * 문제 설명
     *   팀의 막내인 철수는 아메리카노와 카페 라테만 판매하는 카페에서 
     *   팀원들의 커피를 사려고 합니다. 
     *   아메리카노와 카페 라테의 가격은 차가운 것과 뜨거운 것 상관없이 
     *   각각 4500, 5000원입니다. 
     *   
     *   각 팀원에게 마실 메뉴를 적어달라고 하였고, 
     *   그 중에서 메뉴만 적은 팀원의 것은 차가운 것으로 통일하고 
     *   
     *   "아무거나"를 적은 팀원의 것은 
     *   차가운 아메리카노로 통일하기로 하였습니다.
     *   
     *   각 직원이 적은 메뉴가 문자열 배열 order로 주어질 때, 
     *   카페에서 결제하게 될 금액을 return 하는 solution 함수를 작성해주세요. 
     *   
     *
     *
     *제한사항
     *     1 ≤ order의 길이 ≤ 1,000
     *      
     *      
     * 문제해결
     *      
     *      
     *      
     */
    #endregion
    public class 커피_심부름
    {
        static public int solution(string[] order)
        {
            int answer = 0;
            int americano = 0;
            int latte = 0;

            for (int i = 0; i < order.Length; i++)
            {
                if (order[i].Contains("americano") || order[i].Contains("anything"))
                    americano++;
                if (order[i].Contains("latte"))
                    latte++;
            }
            answer += americano * 4500 + latte * 5000;

            return answer;
        }
    }
}
