using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07_Passing_cars
{
  //codility code starts here
  class Solution
  {
    public int solution(int[] A)
    {
      int[] a = new int[A.Length];
      for (int i = 0; i < A.Length; i++)
      {
        a[i] = a[Math.Max(0, i - 1)] + A[i];
      }

      long result = 0;
      for (int i = 0; i < A.Length; i++)
        if (A[i] == 0)
        {
          result += (a[A.Length-1] - a[i]);
        }

      if (result > 1000000000)
      {
        return -1;
      }
      return (int)result;
    }
  }
  //codility code ends here

  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();

      Console.WriteLine(sol.solution(new int[5] { 0, 1, 0, 1, 1})); // 5

      Console.ReadKey();
    }
  }
}
