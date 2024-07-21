using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기
{
    internal class 리스트_자르기___범위_생각하기
    {
        #region 리스트 자르기 __범위 생각하기
        //static public int[] solution(int n, int[] slicer, int[] num_list)
        //{
        //    int[] answer = new int[] { };

        //    List<int> list = new List<int>(num_list);

        //    #region Linq skip(x).take(y) = x부터 y인덱스 까지 (범위 설정 = y - x + 1)
        //    switch (n)
        //    {
        //        case 1:
        //            {
        //                answer = list.Take(slicer[1] + 1).ToArray();
        //            }
        //            break;
        //        case 2:
        //            {
        //                answer = list.Skip(slicer[0]).ToArray();
        //            }
        //            break;
        //        case 3:
        //            {
        //                answer = list.Skip(slicer[0]).Take(slicer[1] - slicer[0] + 1).ToArray();
        //            }
        //            break;
        //        case 4:
        //            {
        //                // 뒤의 인덱스는 뒤의 인덱스 - 처음 인덱스 + 1을 해주면 된다.
        //                int[] temp = list.Skip(slicer[0]).Take(slicer[1] - slicer[0] + 1).ToArray();
        //                list.Clear();

        //                for(int i = 0; i < temp.Length; i++)
        //                {
        //                    if(slicer[2] * i < temp.Length)
        //                        list.Add(temp[slicer[2] * i]);
        //                }
        //                answer = list.ToArray();

        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //    #endregion

        //    foreach (int i in answer)
        //        Console.WriteLine(i);
        //    return answer;
        //}

        //static void Main(string[] args)
        //{
        //    int a = 1;
        //    int[] b = { 1,5,2 };
        //    int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        //    Console.WriteLine($"{solution(a, b, c)}");

        //}
        #endregion
    }
}
