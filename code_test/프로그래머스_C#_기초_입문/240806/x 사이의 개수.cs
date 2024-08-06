using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240806
{
    internal class x_사이의_개수
    {
        static public int[] solution(string myString)
        {
            int[] answer = new int[] { };

            string[] str = myString.Split('x');
            answer = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                answer[i] = str[i].Length;
            }

            foreach (int i in answer)
                Console.WriteLine(i);

            return answer;
        }
    }
}
