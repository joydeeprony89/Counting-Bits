using System;

namespace Counting_Bits
{
  class Program
  {
    static void Main(string[] args)
    {
      Solution s = new Solution();
      int n = 10;
      var answer = s.CountBits(n);
    }
  }

  public class Solution
  {
    public int[] CountBits(int n)
    {
      // its mathametically proven that - 
      //1. for even no, no of one's in a no "n" is same in no "n/2"
      //2. for odd no, no of one's in a no "n" is same in no "n/2" + 1

      int[] dp = new int[n + 1];
      dp[0] = 0;
      for (int i = 1; i <= n; i++)
      {
        // when even
        if (i % 2 == 0)
        {
          dp[i] = dp[i / 2];
        }
        else
        {
          dp[i] = dp[i / 2] + 1;
        }
      }
      return dp;
    }
  }
}
