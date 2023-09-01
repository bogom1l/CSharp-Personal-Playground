namespace DSA_Intro
{
    public class Program //TODO: Ctrl + Alt + '
    {
        private static void Main(string[] args)
        {
            string str1 = "abcdaf";
            string str2 = "acbcf";

            int lcsRecursion = LCS(str1, str2, str1.Length, str2.Length);
            Console.WriteLine("LCS (Recursion): " + lcsRecursion);

            int lcsDynamic = LCS_Dynamic(str1, str2);
            Console.WriteLine("LCS (Dynamic): " + lcsDynamic);
        }

        //LongestCommonSubsequence - Recursion
        private static int LCS(string str1, string str2, int i, int j)
        {
            if (i == 0 || j == 0)
            {
                return 0;
            }

            if (str1[i - 1] == str2[j - 1])
            {
                return 1 + LCS(str1, str2, i - 1, j - 1);
            }

            return Math.Max(LCS(str1, str2, i, j - 1), LCS(str1, str2, i - 1, j));
        }

        //LongestCommonSubsequence - Dynamic Solution
        private static int LCS_Dynamic(string str1, string str2)
        {
            int m = str1.Length;
            int n = str2.Length;

            int[,] temp = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        temp[i, j] = 0;
                    }
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        int currValue1 = temp[i - 1, j - 1] + 1;
                        temp[i, j] = currValue1;
                    }
                    else
                    {
                        int currValue2 = Math.Max(temp[i - 1, j], temp[i, j - 1]);
                        temp[i, j] = currValue2;
                    }
                }
            }

            return temp[m, n];
        }
    }
}