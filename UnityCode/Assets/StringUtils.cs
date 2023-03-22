using System;

namespace StringUtils
{
    /// <summary>
    /// LevenshteinDistance
    /// </summary>
    public static class StringUtils
    {
        public static int LevenshteinDistance(string s, string t)
        {
            int[,] distance = new int[s.Length + 1, t.Length + 1];

            for (int i = 0; i <= s.Length; i++)
            {
                distance[i, 0] = i;
            }

            for (int j = 0; j <= t.Length; j++)
            {
                distance[0, j] = j;
            }

            for (int j = 1; j <= t.Length; j++)
            {
                for (int i = 1; i <= s.Length; i++)
                {
                    if (s[i - 1] == t[j - 1])
                    {
                        distance[i, j] = distance[i - 1, j - 1];
                    }
                    else
                    {
                        distance[i, j] = Math.Min(Math.Min(
                                distance[i - 1, j] + 1,
                                distance[i, j - 1] + 1),
                            distance[i - 1, j - 1] + 1);
                    }
                }
            }

            return distance[s.Length, t.Length];
        }
    }
}
