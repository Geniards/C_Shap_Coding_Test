﻿using System.Text;

namespace 백준
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                string? input = Console.ReadLine();
                num--;
                
                if (input == null)
                {
                    throw new Exception();
                }

                list.Add(input);
            }

            list = list.Distinct()      // 중복 제거
            .OrderBy(w => w.Length)     // 길이 조건
            .ThenBy(w => w)             // 오름차순
            .ToList();

            foreach (string input in list)
                Console.WriteLine(input);

        }
    }
}
