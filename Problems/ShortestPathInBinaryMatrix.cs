using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class ShortestPathInBinaryMatrix
    {
        public int ShortestPathBinaryMatrix(int[][] grid)
        {
            var directions = new[] { new[] { 0, 1 }, new[] { 0, -1 }, new[] { 1, 0 }, new[] { -1, 0 }, new[] { 1, -1 }, new[] { 1, 1 }, new[] { -1, 1 }, new[] { -1, -1 } };
            var m = grid.Length;
            var n = grid[0].Length;

            var origin = new { X = 0, Y = 0 };
            var destination = new { X = m - 1, Y = n - 1 };

            if (grid[origin.X][origin.Y] == 1 || grid[destination.X][destination.Y] == 1)
            {
                return -1;
            }

            var visited = new bool[m, n];
            var queue = new Queue<int[]>();
            queue.Enqueue(new[] { 0, 0 });
            visited[0, 0] = true;
            var count = 0;

            while (queue.Count != 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var poll = queue.Dequeue();
                    if (poll[0] == destination.X && poll[1] == destination.Y)
                    {
                        return count + 1;
                    }

                    foreach (var dir in directions)
                    {
                        var x = dir[0] + poll[0];
                        var y = dir[1] + poll[1];

                        if (x >= 0 && x <= destination.X && y >= 0 && y <= destination.Y && grid[x][y] == 0 && !visited[x, y])
                        {
                            queue.Enqueue(new[] { x, y });
                            visited[x, y] = true;
                        }
                    }
                }
                count++;
            }
            return -1;
        }
    }
}
