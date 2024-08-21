﻿using System.Text;

namespace 백준
{
    public class Program
    {
        static void Main(string[] args)
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
