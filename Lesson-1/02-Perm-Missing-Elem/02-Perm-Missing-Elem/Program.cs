using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Perm_Missing_Elem
{
  //codility code starts here
  class Solution
  {
    public int solution(int[] A)
    {
      long should_be = (long)(A.Length + 1) * (long)(A.Length + 2) / (long)2;
      long is_now = 0;
      foreach (long i in A)
      {
        is_now = (is_now + i); 
      }
      return (int)(should_be - is_now);
    }
  }
  //codility code ends here

  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();
      int[] a = new int[200000];
      for (int i = 0; i < a.Length; i++)
      {
        a[i] = i + 1;
      }
      
      Console.WriteLine(sol.solution(new int[4] {1,2,3,5})); // 4
      Console.WriteLine(sol.solution(new int[8] { 1, 2, 3, 4, 5, 6, 8, 9 })); // 7
      Console.WriteLine(sol.solution(a)); // 200001

      Console.ReadKey();
    }
  }
}