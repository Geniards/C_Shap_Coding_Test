using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.소수찾기
{
    public class 소수찾기_1978_
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

            for (int i = 0; i < inputs.Length; i++)
            {
                ints[i] = int.Parse(inputs[i]);
            }

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] != 1)
                {
                    int temp = ints[i];
                    int numI = 2;

                    while (temp >= numI)
                    {
                        if (ints[i] % numI == 0)
                        {
                            if (numI == ints[i])
                            {
                                answer++;
                                break;
                            }
                            else
                                break;
                        }
                        numI++;
                    }
                }
            }

            Console.WriteLine(answer);
        }
    }
}
