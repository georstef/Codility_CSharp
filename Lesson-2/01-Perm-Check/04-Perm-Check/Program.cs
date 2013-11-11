using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_Perm_Check
{
  //codility code starts here
  class Solution
  {
    public int solution(int[] A)
    {
      Array.Sort(A);
      for (int i = 0; i < A.Length; i++)
      {
        if (A[i] != i + 1)
          return 0;
      }

      return 1;
    }
  }
  //codility code ends here

  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();
      int[] a = new int[100000];
      for (int i = 0; i < a.Length; i++)
      {
        a[i] = i + 2;
      }

      Console.WriteLine(sol.solution(new int[4] { 4, 2, 3, 1 })); // 1
      Console.WriteLine(sol.solution(new int[8] { 1, 2, 3, 4, 4, 6, 8, 7 })); // 0 (double No 4 + missing No 5)
      Console.WriteLine(sol.solution(a)); // 0 (starts from No 2)

      Console.ReadKey();
    }
  }
}
