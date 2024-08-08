using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240808
{
    #region 치킨 쿠폰
    /*
     * 문제 설명
     *    프로그래머스 치킨은 치킨을 시켜먹으면 한 마리당 쿠폰을 한 장 발급합니다. 
     *    쿠폰을 열 장 모으면 치킨을 한 마리 서비스로 받을 수 있고, 
     *    서비스 치킨에도 쿠폰이 발급됩니다. 
     *    시켜먹은 치킨의 수 chicken이 매개변수로 주어질 때 
     *    받을 수 있는 최대 서비스 치킨의 수를 return하도록 solution 함수를 완성해주세요.
     *
     *
     *제한사항
     *      chicken은 정수입니다.
     *      0 ≤ chicken ≤ 1,000,000
     *      
     *      
     * 문제해결
     *      쿠폰으로 시킨 경우도 똑같이 쿠폰을 추가가 되는 부분이 힌트다.
     *      
     *      
     */
    #endregion
    public class 치킨_쿠폰
    {
        static public int solution(int chicken)
        {
            #region 내 풀이
            int answer = chicken / 10;
            int plusChicken = chicken / 10;
            int coupon = chicken % 10;

            while (plusChicken + coupon >= 10)
            {
                answer += plusChicken / 10;
                coupon += plusChicken / 10;
                plusChicken %= 10;

                if (coupon > 0)
                {
                    plusChicken += coupon;
                    coupon = 0;
                }
            }
            return answer;
            #endregion

            #region 다른사람 풀이
            //int coupon = chicken;
            //int serviceChicken = 0;

            //while (coupon >= 10)
            //{
            //    coupon -= 10;

            //    serviceChicken++;
            //    coupon++;
            //}

            //return serviceChicken;
            #endregion
        }
    }
}