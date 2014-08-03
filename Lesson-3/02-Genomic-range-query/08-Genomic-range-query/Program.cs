using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_Genomic_range_query
{
  //codility code starts here
  class Solution
  {
    public int[] solution(string S, int[] P, int[] Q)
    {
      string[] n = new string[5] { "", "A", "C", "G", "T" };
      int[,] s = new int[S.Length+1, 5];
      for (int i = 0; i < S.Length; i++)
      {
        for (int j = 1; j <= 4; j++)
        {
          if (S[i].ToString() == n[j])
          {
            s[i+1,j] = s[i,j] + 1;
          }
          else
          {
            s[i+1,j] = s[i,j];
          }
          
        }
      }

      int[] result = new int[P.Length];
      int to_append = 0;
      for (int i = 0; i < P.Length; i++)
		  {
        if (s[Q[i]+1, 1] - s[P[i], 1] > 0)
        {
          to_append = 1;
        }
        else if (s[Q[i]+1, 2] - s[P[i], 2] > 0)
        {
            to_append = 2;
        }
        else if (s[Q[i]+1, 3] - s[P[i], 3] > 0)
        {
            to_append = 3;
        }
        else
        {
            to_append = 4;
        }
        
        result[i]= to_append;
		}

    return result;
    }
  }
  //codility code ends here

  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();

      int[] ans = sol.solution("CGAACCGT", new int[3] { 0, 1, 5 }, new int[3] { 3, 1, 7 });//[1,3,2]
      for (int i = 0; i < ans.Length; i++)
      {
        Console.WriteLine(ans[i]);  
      }

      Console.ReadKey();
    }
  }
}
