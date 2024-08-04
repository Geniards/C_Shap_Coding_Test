using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240804
{
    internal class _region_다항식_더하기
    {
        #region 다항식 더하기

        //static public string solution(string polynomial)
        //{
        //    string answer = "";
        //    StringBuilder sb = new StringBuilder();
        //    string[] str;
        //    int X = 0;
        //    int num = 0;

        //    str = polynomial.Split(" ");

        //    for (int i = 0; i < str.Length; i += 2)
        //    {
        //        if (str[i].Contains("x"))
        //        {
        //            sb.Append(str[i].Replace("x", string.Empty));

        //            if (sb.ToString() == "")
        //                X += 1;
        //            else
        //            {
        //                X += int.Parse(sb.ToString());
        //                sb.Clear();
        //            }
        //        }
        //        else
        //            num += int.Parse(str[i]);
        //    }

        //    if(num == 0)
        //    {
        //        if (X == 1)
        //            answer = "x";
        //        else
        //        {
        //            sb.Append(X.ToString()+"x");
        //            answer = sb.ToString();
        //        }
        //    }
        //    else
        //    {
        //        if(X == 0)
        //            answer = num.ToString();
        //        else if(X == 1)
        //        {
        //            sb.Append("x + "+ num.ToString());

        //            answer = sb.ToString();
        //        }
        //        else
        //        {
        //            sb.Append(X.ToString()+"x + "+ num.ToString());

        //            answer = sb.ToString();
        //        }
        //    }


        //    return answer;
        //}


        //static void Main(string[] args)
        //{
        //    string a = "x + x + x";
        //    int[] b = { 9, 5 };
        //    int c = 2;

        //    Console.WriteLine(solution(a));
        //}
        #endregion
    }
}
