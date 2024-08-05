namespace Lv1.__x만큼_간격이_있는_n개의_숫자
{
    public class Program
    {
        /*
         * x만큼 간격이 있는 n개의 숫자(12954)
         * 
         * 문제 설명
         *      함수 solution은 정수 x와 자연수 n을 입력 받아, 
         *      x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트를 리턴해야 합니다. 
         *      다음 제한 조건을 보고, 조건을 만족하는 함수, solution을 완성해주세요.
         *      
         * 제한 조건
         *      x는 -10000000 이상, 10000000 이하인 정수입니다.
         *      n은 1000 이하인 자연수입니다.     
         *      
         *      
         * 문제해결
         *      list에 들어가는 i에 대해서 int값으로 하면
         *      13,14번 문제에서 에러가 발생한다.
         */

        static public long[] solution(int x, int n)
        {
            long[] answer = new long[] { };

            List<long> list = new List<long>();
            
            for(long i = 1; i <= n; i++)
            {
                list.Add(x*i);
            }

            return answer = list.ToArray();
        }

        static void Main(string[] args)
        {
            int x = 2;
            int n = 5;

            Console.WriteLine(solution(x, n));
        }
    }
}
