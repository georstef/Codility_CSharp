using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Equi
{
  //codility code starts here
  class Solution
  {
    public int solution(int[] A)
    {
      long[] a = new long[A.Length + 1];
      for (int i = 0; i < A.Length; i++)
      {
        a[i + 1] = a[i] + A[i];
      }

      for (int i = 0; i < A.Length; i++)
      {
        long lsum = a[i] - a[0];
        long rsum = a[A.Length] - a[i + 1];
        if (lsum == rsum)
        {
          return i;
        }
      }
      return -1;
    }
  }
  //codility code ends here

  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();
      Console.WriteLine(sol.solution(new int[7] { -7, 1, 5, 2, -4, 3, 0 }));//3

      Console.ReadKey();
    }
  }
}
