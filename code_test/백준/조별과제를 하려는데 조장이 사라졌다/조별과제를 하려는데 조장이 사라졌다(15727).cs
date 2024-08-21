using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.조별과제를_하려는데_조장이_사라졌다
{
    public class 조별과제를_하려는데_조장이_사라졌다_15727_
    {
        static void solution(string[] args)
        {
            int answer = 0;
            int num = int.Parse(Console.ReadLine());
            int temp = 5;

            while (temp > 0)
            {
                if (num % temp == 0)
                {
                    answer += num / temp;
                    Console.WriteLine(answer);
                    break;
                }
                else
                {
                    answer += num / temp;
                    num %= temp;
                }

                temp--;
            }

        }
    }
}
