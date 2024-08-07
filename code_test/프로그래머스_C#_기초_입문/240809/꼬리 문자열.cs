﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240809
{
    #region 꼬리 문자열
    /*
     * 문제 설명
     *    문자열들이 담긴 리스트가 주어졌을 때, 
     *    모든 문자열들을 순서대로 합친 문자열을 꼬리 문자열이라고 합니다. 
     *    꼬리 문자열을 만들 때 특정 문자열을 포함한 문자열은 제외시키려고 합니다. 
     *    예를 들어 문자열 리스트 ["abc", "def", "ghi"]가 있고 
     *    문자열 "ef"를 포함한 문자열은 제외하고 꼬리 문자열을 만들면 "abcghi"가 됩니다.
     *    
     *    문자열 리스트 str_list와 제외하려는 문자열 ex가 주어질 때, 
     *    str_list에서 ex를 포함한 문자열을 제외하고 만든 꼬리 문자열을 
     *    return하도록 solution 함수를 완성해주세요.
     *
     *
     *제한사항
     *      2 ≤ str_list의 길이 ≤ 10
     *      1 ≤ str_list의 원소의 길이 ≤ 10
     *      1 ≤ ex의 길이 ≤ 5
     *      
     *      
     * 문제해결
     *      문제에서 주어지는 입력값을 잘 입력하자....
     *      
     *      
     */
    #endregion
    public class 꼬리_문자열
    {
        static public string solution(string[] str_list, string ex)
        {
            string answer = "";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str_list.Length; i++)
            {
                if (!str_list[i].Contains(ex))
                    sb.Append(str_list[i]);
            }

            return answer = sb.ToString();
        }
    }
}
