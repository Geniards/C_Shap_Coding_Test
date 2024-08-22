using System.Text;

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

            List<Tuple<int, string>> list = new List<Tuple<int, string>>();

            for (int i = 0; i < num; i++)
            {
                input = Console.ReadLine();
                string[] inputs = input.Split(" ");

                int value = int.Parse(inputs[0]);
                string name = inputs[1];

                list.Add(new Tuple<int, string>(value, name));
            }

            var newList = list.OrderBy(x => x.Item1);

            foreach (var item in newList)
            {
                Console.WriteLine($"{item.Item1} {item.Item2}");
            }
        }
    }
}
