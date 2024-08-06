using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.프로그래머스_C__기초_입문._240806
{
    #region 배열 만들기 6
    /*
     * 문제 설명
     *      0과 1로만 이루어진 정수 배열 arr가 주어집니다. 
     *      arr를 이용해 새로운 배열 stk을 만드려고 합니다.
     *      
     *      i의 초기값을 0으로 설정하고 i가 arr의 길이보다 작으면 다음을 반복합니다.
     *      
     *      만약 stk이 빈 배열이라면 arr[i]를 stk에 추가하고 i에 1을 더합니다.
     *      stk에 원소가 있고, stk의 마지막 원소가 arr[i]와 같으면 
     *      stk의 마지막 원소를 stk에서 제거하고 i에 1을 더합니다.
     *      
     *      stk에 원소가 있는데 stk의 마지막 원소가 arr[i]와 다르면 
     *      stk의 맨 마지막에 arr[i]를 추가하고 i에 1을 더합니다.
     *      
     *      위 작업을 마친 후 만들어진 stk을 return 하는 solution 함수를 완성해 주세요.
     *      단, 만약 빈 배열을 return 해야한다면 [-1]을 return 합니다.
     *      
     *      
     * 제한사항
     *      1 ≤ arr의 길이 ≤ 1,000,000
     *      arr의 원소는 0 또는 1 입니다.
     *      
     *      
     * 문제해결
     *      Stack을 써서 풀면 편하다...
     */
    #endregion

    public class 배열_만들기_6
    {
        static public int[] solution(int[] arr)
        {
            int[] answer = new int[] { };
            #region NoStack
            //List<int> list = new List<int>();
            //int temp = 0;
            //while (temp < arr.Length)
            //{
            //    if (list.Count == 0)
            //    {
            //        list.Add(arr[temp]);
            //        temp++;
            //    }
            //    else if (list.Count > 0 && list[list.Count - 1] == arr[temp])
            //    {
            //        list.RemoveAt(list.Count - 1);
            //        temp++;
            //    }
            //    else
            //    {
            //        list.Add(arr[temp]);
            //        temp++;
            //    }
            //}

            //if (list.Count == 0)
            //    answer = new int[1] { -1 };
            //else
            //    answer = list.ToArray();
            #endregion

            #region Stack
            //Stack<int> stack = new Stack<int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (stack.Count == 0)
            //        stack.Push(arr[i]);
            //    else if (stack.Peek() == arr[i])
            //        stack.Pop();
            //    else if (stack.Peek() != arr[i])
            //        stack.Push(arr[i]);
            //}

            //if (stack.Count == 0) 
            //    stack.Push(-1);

            //int[] answerArr = new int[stack.Count];
            //for (int i = stack.Count - 1; i >= 0; i--)
            //{
            //    answerArr[i] = stack.Pop();
            //}
            //return answerArr;
            #endregion
            return answer;
        }
    }
}
