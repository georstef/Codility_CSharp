using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_Frog_River_One
{
  //codility code starts here
  class Solution
  {
    public int solution(int X, int[] A) 
    {
      //this solution needs => using System.Linq;
      int[] a = Enumerable.Repeat(-1, X).ToArray();

      for (int i = 0; i < A.Length; i++)
      {
        if (a[A[i]-1] < 0)
        {
          a[A[i]-1] = i;
        }
      }
      if (a.Contains(-1))
      {
        return -1;
      }
      else
      {
        return a.Max();
      }
    }
  }
  //codility code ends here

  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();

      Console.WriteLine(sol.solution(5, new int[8] { 1, 3, 1, 4, 2, 3, 5, 4 })); // 6
      Console.WriteLine(sol.solution(4, new int[5] { 1, 2, 3, 1, 1 })); // -1 (cannot cross 4 does not exists)
      Console.WriteLine(sol.solution(1, new int[1] { 1 })); // 1 

      Console.ReadKey();
    }
  }
}
