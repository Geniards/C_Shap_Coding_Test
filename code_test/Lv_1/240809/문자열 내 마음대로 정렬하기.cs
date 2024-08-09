using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_1._240809
{
    #region 문자열 내 마음대로 정렬하기
    /*
     * 문제 설명
     *   문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때, 
     *   각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬하려 합니다. 
     *   예를 들어 strings가 ["sun", "bed", "car"]이고 n이 1이면 
     *   각 단어의 인덱스 1의 문자 "u", "e", "a"로 strings를 정렬합니다.
     *
     *
     *제한사항
     *     strings는 길이 1 이상, 50이하인 배열입니다.
     *     strings의 원소는 소문자 알파벳으로 이루어져 있습니다.
     *     strings의 원소는 길이 1 이상, 100이하인 문자열입니다.
     *     모든 strings의 원소의 길이는 n보다 큽니다.
     *     인덱스 1의 문자가 같은 문자열이 여럿 일 경우, 
     *     사전순으로 앞선 문자열이 앞쪽에 위치합니다.
     *      
     *      
     * 문제해결
     *      정렬의 순서에 따라 식이 달라진다.
     *      
     *      
     */
    #endregion
    public class 문자열_내_마음대로_정렬하기
    {
        static public string[] solution(string[] strings, int n)
        {
            #region 처음식 
            ///*
            // * 1. 사전순 2. n번째 글자들을 사전순 진행하다 보니  
            // * n번째 글자에서 같은 경우 사전 순으로 정렬 하는 부분에서 
            // * 같은 문자열이 두개 존재 하는 경우에서 한개만 입력받는 문제가 발생.
            // */
            //string[] answer = new string[] { };
            //List<string> list = new List<string>();
            //List<string> temp = new List<string>();

            //// 1. 사전 순으로 정렬.
            //Array.Sort(strings);

            //for (int i = 0; i < strings.Length; i++)
            //{
            //    list.Add(strings[i][n].ToString());
            //}

            //// 2. n번째 문자들 사전순으로 정렬
            //list.Sort();

            //for (int j = 0; j < list.Count; j++)
            //{
            //    for (int i = 0; i < strings.Length; i++)
            //    {
            //        // 해당 부분에서 문제 발생!!!
            //        // 같은 문자열이 두개인 strings에서는 한개만 적용이 되기에 문제가 발생한다.
            //        if (strings[i].Contains(list[j]) && n == strings[i].IndexOf(list[j]))
            //        {
            //            if (!temp.Contains(strings[i]))
            //                temp.Add(strings[i]);
            //        }
            //    }
            //}

            //foreach (var s in temp)
            //    Console.WriteLine(s);

            //return answer = temp.ToArray();
            #endregion

            #region 새로 만든식  

            /*
             * 정렬순서 1. n번째로 정렬하고 2. 사전순서로 진행
             * 중복부분의 문제가 해결된다.
             */

            string[] answer = new string[] { };
            List<string> list = new List<string>();

            // n번째 글자를 담으면서 해당 문자열을 붙여서 진행.
            for (int i = 0; i < strings.Length; i++)
            {
                list.Add(strings[i][n].ToString() + strings[i]);
            }

            // 1. n번째 문자로 정렬됨과 동시에
            // 2. 사전 순으로 정렬된다.
            list.Sort();

            for (int i = 0; i < strings.Length; i++)
            {
                // 맨 앞에 붙었던 n번째 문자열 제거
                list[i] = list[i].Substring(1);
            }

            foreach (var s in list)
                Console.WriteLine(s);

            return answer = list.ToArray();
            #endregion

        }
    }
}
