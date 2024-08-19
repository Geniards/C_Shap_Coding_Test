using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.백준.최단거리
{
    #region 최단경로(1753)
    /*
     * 문제 설명
     *   방향그래프가 주어지면 주어진 시작점에서 
     *   다른 모든 정점으로의 최단 경로를 구하는 프로그램을 작성하시오. 
     *   단, 모든 간선의 가중치는 10 이하의 자연수이다.
     *   
     * 입력
     *   첫째 줄에 정점의 개수 V와 간선의 개수 E가 주어진다. 
     *   (1 ≤ V ≤ 20,000, 1 ≤ E ≤ 300,000) 
     *   모든 정점에는 1부터 V까지 번호가 매겨져 있다고 가정한다. 
     *   
     *   둘째 줄에는 시작 정점의 번호 K(1 ≤ K ≤ V)가 주어진다. 
     *   
     *   셋째 줄부터 E개의 줄에 걸쳐 각 간선을 나타내는 
     *   세 개의 정수 (u, v, w)가 순서대로 주어진다. 
     *   
     *   이는 u에서 v로 가는 가중치 w인 간선이 존재한다는 뜻이다. 
     *   u와 v는 서로 다르며 w는 10 이하의 자연수이다. 
     *   서로 다른 두 정점 사이에 여러 개의 간선이 존재할 수도 있음에 유의한다.
     *
     * 출력
     *   첫째 줄부터 V개의 줄에 걸쳐, i번째 줄에 i번 정점으로의 최단 경로의 경로값을 출력한다.
     *   시작점 자신은 0으로 출력하고, 경로가 존재하지 않는 경우에는 INF를 출력하면 된다.
     *
     *제한사항
     *     
     *      
     *      
     * 문제해결
     *      다른 접근 방식을 생각해보자
     *      
     *      
     */
    #endregion

    public class Program
    {
        static public void Input(out int[] num)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            num = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                num[i] = int.Parse(numbers[i]);
            }
        }
        static public void solution()
        {
            const int INF = int.MaxValue;
            Input(out int[] num);

            // 맵의 크기 
            int vertex = num[0];
            int edge = num[1];

            // 맵 초기화
            int[,] graph = new int[vertex, vertex];
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                for (int j = 0; j < graph.GetLength(0); j++)
                {
                    graph[i, j] = INF;
                }
            }

            // 시작 정점
            Input(out num);
            int start = num[0] - 1;

            // 정점간의 거리 값 입력
            int temp = 0;
            while (temp < edge)
            {
                Input(out num);
                graph[num[0] - 1, num[1] - 1] = num[2];
                temp++;
            }

            // 다익스트라 알고리즘 변수
            bool[] visited = new bool[vertex];       // 각 정점의 탐색 여부
            int[] distance = new int[vertex];        // 각 정점의 최단 거리
            PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();
            priorityQueue.Enqueue(start, 0);
            distance[start] = 0;

            foreach (var next in graph)
            {
                Console.WriteLine(next);
            }

            while (priorityQueue.Count > 0)
            {
                int cur = priorityQueue.Dequeue();
                if (visited[cur])
                    continue;
                else
                {
                    visited[cur] = true;

                    foreach (var next in graph)
                    {
                        Console.WriteLine(next);
                    }
                }

            }







            for (int i = 0; i < vertex; i++)
            {
                if (distance[i] != INF)
                    Console.WriteLine($"{distance[i]}");
                else
                    Console.WriteLine("INF");
            }

            #region 메모리 초과
            //const int INF = int.MaxValue;
            //Input(out int[] num);

            //// 맵의 크기 
            //int vertex = num[0];
            //int edge = num[1];

            //// 맵 초기화
            //int[,] graph = new int[vertex, vertex];
            //for (int i = 0; i < graph.GetLength(0); i++)
            //{
            //    for (int j = 0; j < graph.GetLength(0); j++)
            //    {
            //        graph[i, j] = INF;
            //    }
            //}

            //// 시작 정점
            //Input(out num);
            //int start = num[0] - 1;

            //// 정점간의 거리 값 입력
            //int temp = 0;
            //while (temp < edge)
            //{
            //    Input(out num);
            //    graph[num[0] - 1, num[1] - 1] = num[2];
            //    temp++;
            //}

            //// 다익스트라 알고리즘 변수
            //bool[] visited = new bool[vertex];       // 각 정점의 탐색 여부
            //int[] distance = new int[vertex];        // 각 정점의 최단 거리
            //int[] parent = new int[vertex];          // 각 탐색한 정점이 누구인지

            //for (int i = 0; i < vertex; i++)
            //{
            //    visited[i] = false;
            //    distance[i] = INF;
            //    parent[i] = -1;
            //}
            //distance[start] = 0;

            //for (int i = 0; i < vertex; i++)
            //{
            //    // 1. 가장 가까운 정점부터 선택
            //    int minIndex = -1;      // 가장 작은거리를 가진 위치를 기록해두기 위한 변수
            //    int minCost = INF;      // 가장 작은 거리 수치를 저장해둘 변수

            //    for (int j = 0; j < vertex; j++)
            //    {
            //        // 방문한적 없는 곳과 거리가 가장 작은 정점(가까운 정점)
            //        if (visited[j] == false && distance[j] < minCost)
            //        {
            //            minIndex = j;
            //            minCost = distance[j];
            //        }
            //    }
            //    // 연결되어 있으면서 탐색한 적이 없는 정점이 없는 경우
            //    if (minIndex < 0)
            //        break;

            //    // 다음번에 찾았을시 이미 방문했다고 표시.
            //    visited[minIndex] = true;

            //    // 2. 선택한 정점을 거쳐서 더 짧아지는 경우 갱신
            //    for (int j = 0; j < vertex; j++)
            //    {
            //        // distance[j] = 시작 -> 목적지
            //        // distance[minIndex] = 시작 -> 선택한 정점
            //        // graph[minIndex, j] = 선택한 정점 -> 목적지

            //        if (distance[j] > distance[minIndex] + graph[minIndex, j]
            //            && distance[minIndex] + graph[minIndex, j] > -1)
            //        {
            //            distance[j] = distance[minIndex] + graph[minIndex, j];
            //            parent[j] = minIndex;   // 탐색한 정점을 변경
            //        }
            //    }
            //}

            //for (int i = 0; i < vertex; i++)
            //{
            //    if (distance[i] != INF)
            //        Console.WriteLine($"{distance[i]}");
            //    else
            //        Console.WriteLine("INF");
            //}
            #endregion
        }
        //static void Main(string[] args)
        //{
        //    solution();
        //    Console.WriteLine();
        //}
    }
}
