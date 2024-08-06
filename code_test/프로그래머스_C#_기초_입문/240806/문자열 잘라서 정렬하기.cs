using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240806
{
    internal class 문자열_잘라서_정렬하기
    {
        static public string[] solution(string myString)
        {
            string[] answer = myString.Split('x');
            List<string> list = new List<string>();

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] != (""))
                    list.Add(answer[i]);
            }
            list.Sort();

            foreach (var i in list)
                Console.WriteLine(i);

            return answer = list.ToArray();
        }
    }
}
