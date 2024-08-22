using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.An_Easy_Peasy_Problem
{
    public class An_Easy_Peasy_Problem_30214_
    {
        static void solution(string[] args)
        {
            string? input = Console.ReadLine();

            if (input == null)
            {
                throw new Exception();
            }

            string[] inputs = input.Split(" ");
            double[] ints = new double[inputs.Length];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(inputs[i]);
            }


            if (ints[0] >= ints[1] / 2)
                Console.WriteLine("E");
            else
            {
                Console.WriteLine("H");
            }

        }
    }
}
