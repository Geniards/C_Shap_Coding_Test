using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_test.Lv_2._240810
{
    #region 게임 맵 최단거리(1844)
    /*
     * 문제 설명
     *   ROR 게임은 두 팀으로 나누어서 진행하며, 
     *   상대 팀 진영을 먼저 파괴하면 이기는 게임입니다. 
     *   따라서, 각 팀은 상대 팀 진영에 최대한 빨리 도착하는 것이 유리합니다.
     *   
     *   게임 맵의 상태 maps가 매개변수로 주어질 때, 
     *   캐릭터가 상대 팀 진영에 도착하기 위해서 
     *   지나가야 하는 칸의 개수의 최솟값을 return 하도록 solution 함수를 완성해주세요. 
     *   단, 상대 팀 진영에 도착할 수 없을 때는 -1을 return 해주세요.
     *
     *
     *제한사항
     *     maps는 n x m 크기의 게임 맵의 상태가 들어있는 2차원 배열로, 
     *     n과 m은 각각 1 이상 100 이하의 자연수입니다.
     *     
     *     n과 m은 서로 같을 수도, 다를 수도 있지만, 
     *     n과 m이 모두 1인 경우는 입력으로 주어지지 않습니다.
     *     
     *     maps는 0과 1로만 이루어져 있으며, 
     *     0은 벽이 있는 자리, 1은 벽이 없는 자리를 나타냅니다.
     *     
     *     처음에 캐릭터는 게임 맵의 좌측 상단인 (1, 1) 위치에 있으며, 
     *     상대방 진영은 게임 맵의 우측 하단인 (n, m) 위치에 있습니다.
     *      
     *      
     * 문제해결
     *      BFS의 원리를 이해하고 풀자
     *      
     *      
     */
    #endregion
    public class 게임_맵_최단거리
    {
        static public int solution(int[,] maps)
        {
            #region 풀이
            int w = maps.GetLength(0);
            int h = maps.GetLength(1);

            Queue<(int, int)> queue = new Queue<(int x, int y)>();

            // 부모의 위치
            Dictionary<(int x, int y), (int x, int y)> parents = new Dictionary<(int x, int y), (int x, int y)>();
            // 움직일 방향(상하좌우)
            (int, int)[] dirs = new (int x, int y)[4] { (-1, 0), (1, 0), (0, -1), (0, 1) };

            // 시작위치 설정
            queue.Enqueue((0, 0));

            // 시작위치 초기화
            maps[0, 0] = 0;

            // 도착지점 
            bool found = false;

            // 움직일 경로를 파악할게 남았다면 확인한다.
            while (queue.Count > 0)
            {
                // 현재 위치
                (int x, int y) cur = queue.Dequeue();

                // 도착지점에 도달했는지 파악
                if (cur.x == w - 1 && cur.y == h - 1) // 도달!
                {
                    found = true;
                    break;
                }

                foreach ((int x, int y) dir in dirs)
                {
                    // 시작점(0,0)에서 한칸씩 상 하 좌 우 이동 후
                    // 움직일 공간이 있는지를 파악
                    (int x, int y) p = (cur.x + dir.x, cur.y + dir.y);

                    // 이동후 좌표가 범위를 벗어날시 다른 움직임을 확인한다.
                    if (p.x < 0 || p.x >= w || p.y < 0 || p.y >= h)
                        continue;

                    // 아직 움직이지 않은 곳이라면 1 움직인 곳은 0으로 표시한다.
                    if (maps[p.x, p.y] != 1)
                        continue;


                    parents[p] = cur;   // 이동하기 전 위치를 부모의 값으로 저장한다.
                    queue.Enqueue(p);   // 이동한 위치의 값을 큐에 저장 후 다음에 불러내도록 한다.
                    maps[p.x, p.y] = 0; // 방문했으니 0으로 표시
                }
            }

            if (found)
            {
                int length = 0;
                // 목적지의 부모의 위치
                (int x, int y) cur = parents[(w - 1, h - 1)];

                // 시작점까지 거슬러 올라가자(최단 루트)
                while (!(cur.x == 0 && cur.y == 0))
                {
                    cur = parents[cur];

                    // 이때 비용이 있다면 다 더해주면 최단 비용.
                    length++;
                }
                length += 2; // 시작과 끝 더함
                return length;
            }
            else
            {
                return -1;
            }
            #endregion

        }
    }
}
