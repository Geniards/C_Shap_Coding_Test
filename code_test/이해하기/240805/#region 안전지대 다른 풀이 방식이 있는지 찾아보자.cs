using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기._240805
{
    internal class _region_안전지대_다른_풀이_방식이_있는지_찾아보자
    {
        #region 안전지대 다른 풀이 방식이 있는지 찾아보자...

        //static public int solution(int[,] board)
        //{
        //    int answer = 0;
        //    bool[,] bBoard = new bool[board.GetLength(0), board.GetLength(1)];
        //    for (int i = 0; i < board.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < board.GetLength(1); j++)
        //        {
        //                bBoard[i, j] = true;
        //        }
        //    }

        //    for (int i = 0; i < board.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < board.GetLength(1); j++)
        //        {
        //            if (board[i, j] == 1)
        //            {
        //                for (int x = -1; x <= 1; x++)
        //                {
        //                    for (int y = -1; y <= 1; y++)
        //                    {
        //                        int newX = i + x;
        //                        int newY = j + y;
        //                        if (newX >= 0 && newX < board.GetLength(0) && newY >= 0 && newY < board.GetLength(1))
        //                        {
        //                            bBoard[newX, newY] = false;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    foreach (var v in bBoard)
        //    {
        //        if (v) answer++;
        //    }

        //    return answer;
        //}

        //static void Main(string[] args)
        //{
        //    int[,] a = { { 1, 0, 1, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0}, { 0, 0, 1, 0, 0}, { 0, 0, 0, 0, 0} };
        //    int[] b = { 9, 5 };
        //    int c = 2;

        //    Console.WriteLine(solution(a));
        //}
        #endregion
    }
}
