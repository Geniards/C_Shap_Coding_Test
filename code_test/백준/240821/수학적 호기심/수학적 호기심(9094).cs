using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.수학적_호기심
{
    public class 수학적_호기심_9094_
    {
        static void solution(string[] args)
        {
            int answer = 0;
            string? input = Console.ReadLine();
            List<int> list = new List<int>();
            if (input == null)
            {
                throw new Exception();
            }

            int num = int.Parse(input);

            while (num > 0)
            {
                input = Console.ReadLine();

                string[] inputs = input.Split(" ");
                int[] ints = new int[inputs.Length];
                ints[0] = int.Parse(inputs[0]);
                ints[1] = int.Parse(inputs[1]);

                for (int i = 1; i < ints[0]; i++)
                {
                    for (int j = i + 1; j < ints[0]; j++)
                    {
                        if ((Math.Pow(i, 2) + Math.Pow(j, 2) + ints[1]) % (i * j) == 0)
                            answer++;
                    }
                }
                list.Add(answer);
                answer = 0;
                num--;
            }

            foreach (int i in list)
                Console.WriteLine(i);

        }
    }
}
