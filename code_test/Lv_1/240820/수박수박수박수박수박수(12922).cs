using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240820
{
    #region 수박수박수박수박수박수?(12922)

    /*
     * 문제 설명
     *   길이가 n이고, "수박수박수박수...."와 같은 패턴을 유지하는 
     *   문자열을 리턴하는 함수, solution을 완성하세요. 
     *   예를들어 n이 4이면 "수박수박"을 리턴하고 3이라면 "수박수"를 리턴하면 됩니다.
     *   
     * 제한사항
     *   n은 길이 10,000이하인 자연수입니다.
     *
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion
    public class 수박수박수박수박수박수_12922_
    {
        static public string solution(int n)
        {
            string answer = "";

            StringBuilder sb = new StringBuilder();
            int temp = 0;
            while (n > temp)
            {

                if (temp % 2 == 0)
                    sb.Append("수");
                else
                    sb.Append("박");

                temp++;
            }


            return answer = sb.ToString();
        }
    }
}
