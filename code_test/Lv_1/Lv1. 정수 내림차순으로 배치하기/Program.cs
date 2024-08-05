using System.Text;

namespace Lv1._정수_내림차순으로_배치하기
{
    /*
       * 정수_내림차순으로_배치하기(12933)
       * 
       * 문제 설명
       *      함수 solution은 정수 n을 매개변수로 입력받습니다. 
       *      n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴해주세요. 
       *      예를들어 n이 118372면 873211을 리턴하면 됩니다.
       *      
       * 제한 조건
       *      n은 1이상 8000000000 이하인 자연수입니다.
       *          
       *      
       *      
       * 문제해결
       *      stringBuilder로 받은 다음 list로 넘겨줘서 처리함
       *      char[]형으로 받아서 Array로 처리해도 괜찮을듯 하다.
       */

    public class Program
    {
        static public long solution(long n)
        {
            long answer = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append(n.ToString());

            List<long> list = new List<long>();

            foreach (var c in sb.ToString())
            {
                list.Add(long.Parse(c.ToString()));
            }
            sb.Clear();

            list.Sort();
            list.Reverse();

            foreach (var c in list) 
                sb.Append(c.ToString());

            return answer = long.Parse(sb.ToString());
        }

        static void Main(string[] args)
        {
            long n = 118372;

            Console.WriteLine(solution(n));
        }
    }
}
