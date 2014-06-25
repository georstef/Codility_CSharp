using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Prefix_set
{
  //codility code starts here
  class Solution
  {
    public int solution(int[] A)
    {
      int result = 0;
      int[] a = new int[A.Length];
      for (int i = 0; i < A.Length; i++)
      {
        if (a[A[i]] == 0)
        {
          a[A[i]] = 1;
          result = i;
        }
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
      Console.WriteLine(sol.solution(new int[5] { 2, 2, 1, 0, 1 }));//3

      Console.ReadKey();
    }
  }
}
