namespace Lv1._자연수_뒤집어_배열로_만들기
{
    /*
        * 자연수 뒤집어 배열로 만들기(12932)
        * 
        * 문제 설명
        *      자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴해주세요. 
        *      예를들어 n이 12345이면 [5,4,3,2,1]을 리턴합니다.
        *      
        * 제한 조건
        *      n은 10,000,000,000이하인 자연수입니다.
        *          
        *      
        *      
        * 문제해결
        *      long형을 문자열로 바꿔서 뒤집고 다시 바꿔주기
        */


    public class Program
    {

        static public int[] solution(long n)
        {
            int[] answer = new int[] { };
            string str = new string(n.ToString().Reverse().ToArray());
            
            List<int> list = new List<int>();
            
            foreach (var c in str)
            {
                list.Add(int.Parse(c.ToString()));
            }
            return answer = list.ToArray();
        }

        static void Main(string[] args)
        {
            int n = 12345;

            Console.WriteLine(solution(n));

        }
    }
}
