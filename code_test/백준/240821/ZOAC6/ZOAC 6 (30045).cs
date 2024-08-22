using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.ZOAC6
{
    public class ZOAC_6__30045_
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

            while (num > 0)
            {
                input = Console.ReadLine();

                if (input.Contains("01") || input.Contains("OI"))
                    answer++;

                num--;
            }

            Console.WriteLine(answer);

        }
    }
}
