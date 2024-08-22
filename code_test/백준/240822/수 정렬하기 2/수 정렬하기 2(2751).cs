using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.수_정렬하기_2
{
    public class 수_정렬하기_2_2751_
    {
        static void solution(string[] args)
        {
            int answer = 0;
            string? input = Console.ReadLine();
            if (input == null)
            {
                throw new Exception();
            }

            int num = int.Parse(input);
            int[] ints = new int[num];
            int i = 0;
            while (num > i)
            {
                input = Console.ReadLine();
                ints[i] = int.Parse(input);
                i++;
            }

            Array.Sort(ints);

            // 시간초과
            //foreach (var v in ints)
            //{
            //    Console.WriteLine(v);
            //}

            // 시간초과
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.WriteLine(ints[i]);
            //}

            // 통과
            StringBuilder sb = new StringBuilder(string.Join(" ", ints));
            Console.WriteLine(sb.ToString());
        }
    }
}
