using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.단어정렬
{
    public class 단어정렬_1181_
    {
        static void solution(string[] args)
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
