using System;

namespace тренировка
{
    class Program
    {

        public static int[] board;

        public static bool check(int i, int j, int k)
        {
            if (k == i) return true;
            else return board[k] != j && (i - k) != (j - board[k]) && (i - k) != (board[k] - j) && check(i, j, k + 1);
        }

        public static int put_queen(int n, int i, int j)
        {
            if (i == n) return 1;
            else
            {
                if (j < n)
                {
                    int r = 0;
                    if (check(i, j, 0))
                    {
                        board[i] = j;
                        r = put_queen(n, i + 1, 0);
                    }
                    return r + put_queen(n, i, j + 1);
                }
                else return 0;
            }
        }

        public static void Main()
        {
            board = new int[10];
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(put_queen(n, 0, 0));
        }
    }
}
