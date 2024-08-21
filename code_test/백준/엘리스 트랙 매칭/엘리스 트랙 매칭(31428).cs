using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.엘리스_트랙_매칭
{
    public class 엘리스_트랙_매칭_31428_
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

            input = Console.ReadLine();
            string? input2 = Console.ReadLine();

            string[] inputs = input.Split(" ");

            foreach (string i in inputs)
            {
                if (i == input2)
                    answer++;
            }

            Console.WriteLine(answer);

        }
    }
}
