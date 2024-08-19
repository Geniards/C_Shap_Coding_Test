using System.Text;

namespace 백준
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> sb = new List<string>();

            while (true)
            {
                string? input = Console.ReadLine();
                if (input == null)
                {
                    throw new Exception();
                }

                string[] inputs = input.Split(" ");
                List<int> list = new List<int>();

                list.Add(int.Parse(inputs[0]));
                list.Add(int.Parse(inputs[1]));
                list.Add(int.Parse(inputs[2]));

                if (list[0] == 0 && list[1] == 0 && list[2] == 0)
                    break;

                list.Sort();

                if (Math.Pow(list[0], 2) + Math.Pow(list[1], 2) == Math.Pow(list[2], 2))
                {
                    sb.Add("right");
                    list.Clear();
                }
                else
                {
                    sb.Add("wrong");
                    list.Clear();
                }
            }

            foreach (string s in sb)
                Console.WriteLine(s);

        }
    }
}
