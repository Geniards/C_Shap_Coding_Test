using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.이해하기
{
    internal class 모스부호__1__Split__으로_배열_만들어서_풀기
    {
        #region  모스부호 (1)       //Split()으로 배열 만들어서 풀기 
        //static public string solution(string letter)
        //{
        //    string answer = "";
        //    string[] mose = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        //    int asciiNum = 97;  //65 = 'a',  97 = 'A'

        //    //Split(나누고싶은 곳); ()의 중복되는 곳을 기점으로 배열로 만듬.
        //    string[] letter_str = letter.Split(' ');

        //    //알파벳 받는 곳
        //    List<char> Alpha_list = new List<char>();
        //    StringBuilder sb = new StringBuilder();

        //    //알파벳 list생성
        //    for (int i = 0; i < mose.Length; i++)
        //    {
        //        Alpha_list.Add(Convert.ToChar(asciiNum++));
        //    }


        //    for (int i = 0; i < letter_str.Length; i++)
        //    {
        //        for (int j = 0; j < mose.Length; j++)
        //        {
        //            if (letter_str[i] == mose[j])
        //            {
        //                sb.Append(Alpha_list[j]);
        //            }
        //        }
        //    }

        //    return answer = sb.ToString();


        //    //다른 사람들 풀이 간단하게 나옴...
        //    //foreach (string t in letter.Split(' '))
        //    //{
        //    //    answer += Convert.ToChar(Array.IndexOf(mose, t) + 97);
        //    //}

        //    //return answer;
        //}

        //static void Main(string[] args)
        //{
        //    string a = ".... . .-.. .-.. ---";

        //    Console.WriteLine($"{solution(a)}");

        //}
        #endregion
    }
}
