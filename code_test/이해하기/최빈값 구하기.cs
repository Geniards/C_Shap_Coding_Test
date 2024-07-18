using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기
{
    internal class 최빈값_구하기
    {
        #region  최빈값 구하기    
        //static int solution(int[] array)
        //{
        //    int answer = 0;
        //    int arrMax = 0;

        //    // 배열안에 가장 큰 수 찾기
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if(array[i] > arrMax)
        //            arrMax = array[i];
        //    }

        //    //가장 큰수에 맞게 count배열을 크기 생성
        //    int[] count = new int[arrMax+1];    //arrMax의 값도 포함해야하기에 + 1

        //    int coutMax = 0;
        //    int num = 0;

        //    // array의 배열에서 가장 많은 숫자를 인덱스로 몇개 나오는지 count에 저장하기
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        count[array[i]]++;
        //    }

        //    // 저장된 count의 인덱스 중 최고 값 = array에서 가장 많은 수의 갯수
        //    for (int i = 0; i < count.Length; i++)
        //    {
        //        if (count[i] > coutMax)
        //        {
        //            coutMax = count[i];
        //            answer = i;
        //        }
        //    }

        //    // count 배열중 가장 많이 나온 개수랑 같은 개수가 있는지 찾기
        //    for (int i = 0; i < count.Length; i++)
        //    {
        //        if (count[i] == coutMax)
        //        {
        //            num++;
        //        }
        //    }

        //    // 개수가 같은 값이 1개 이상인 경우 찾기
        //    if (num > 1)
        //    {
        //        answer = -1;
        //    }


        //    return answer;
        //}

        //static void Main(string[] args)
        //{
        //    int[] a = { 1, 2, 3, 3, 3, 4 };

        //    Console.WriteLine($"{solution(a)}");

        //}
        #endregion

    }
}
