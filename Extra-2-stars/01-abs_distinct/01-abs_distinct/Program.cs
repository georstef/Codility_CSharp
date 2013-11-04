using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_abs_distinct
{
  //codility code starts here
  class Solution
  {
    public int solution(int[] A)
    {
      //this solution needs => using System.Collections.Generic;
      HashSet<long> a = new HashSet<long>();
      foreach (long item in A)
      {
        a.Add(Math.Abs(item));
      }
      return a.Count;
    }
  }
  //codility code ends here

  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();
      Console.WriteLine(sol.solution(new int[6] { -5, -3, -1, 0, 3, 6 }));//5
      Console.WriteLine(sol.solution(new int[3] { -3, 3, 1 }));//2

      Console.ReadKey();
    }
  }
}
