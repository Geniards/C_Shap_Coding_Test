using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준._240822.나이순_정렬
{
    public class 나이순_정렬_10814_
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

            #region 최단시간 효율
            //// 빠른 입력을 위해 StringBuilder를 사용
            //StringBuilder sb = new StringBuilder();

            //// 전체 입력을 한 번에 읽기
            //string[] lines = Console.In.ReadToEnd().Split('\n');

            //// 첫 번째 줄은 총 입력의 수
            //int num = int.Parse(lines[0]);

            //// 입력받은 데이터들을 저장할 리스트
            //List<(int Age, string Name)> members = new List<(int Age, string Name)>();

            //// 각 줄을 처리하여 리스트에 추가
            //for (int i = 1; i <= num; i++)
            //{
            //    string[] inputs = lines[i].Split(' ');
            //    int age = int.Parse(inputs[0]);
            //    string name = inputs[1];
            //    members.Add((age, name));
            //}

            //// 나이 순으로 정렬
            //var sortedMembers = members.OrderBy(m => m.Age);

            //// 정렬된 리스트를 StringBuilder를 사용하여 출력
            //foreach (var member in sortedMembers)
            //{
            //    sb.AppendLine($"{member.Age} {member.Name}");
            //}

            //// 결과를 한 번에 출력
            //Console.Write(sb.ToString());
            #endregion
        }
    }
}
