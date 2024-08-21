using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.수빈이와_수열
{
    public class 수빈이와_수열_10539_
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

            string[] inputs = input.Split(" ");
            int[] ints = new int[num];
            int[] B = new int[num];


            for (int i = 0; i < num; i++)
            {
                ints[i] = int.Parse(inputs[i]);
            }

            for (int i = 0; i < num; i++)
            {
                B[i] = ints[i] * (i + 1) - answer;
                answer += B[i];
            }

            foreach (int i in B)
                Console.Write($"{i} ");

        }
    }
}
