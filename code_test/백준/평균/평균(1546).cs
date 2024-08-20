using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.평균
{
    public class 평균_1546_
    {
        static void solution(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            string? input = Console.ReadLine();
            if (input == null)
            {
                throw new Exception();
            }

            string[] inputs = input.Split(" ");
            int[] ints = new int[inputs.Length];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(inputs[i]);
                sum += ints[i];
            }
            int max = ints.Max();

            double avg = (100 * sum) / max;

            Console.WriteLine(avg / num);
        }
    }
}
