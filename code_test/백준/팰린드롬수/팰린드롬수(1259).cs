using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.팰린드롬수
{
    public class 팰린드롬수_1259_
    {
        public void solution()
        {
            List<string> sb = new List<string>();

            while (true)
            {
                string? input = Console.ReadLine();
                if (input == null)
                {
                    throw new Exception();
                }

                if (input == "0")
                    break;

                char[] chars = input.ToCharArray();

                Array.Reverse(chars);
                string str = new string(chars);

                if (input == str)
                    sb.Add("yes");
                else
                    sb.Add("no");
            }

            foreach (string s in sb)
                Console.WriteLine(s);

        }
    }
}
