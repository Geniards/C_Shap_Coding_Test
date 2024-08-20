namespace 팰린드롬수_1259_
{
    internal class Program
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
