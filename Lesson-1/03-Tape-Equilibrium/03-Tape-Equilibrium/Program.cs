using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_Tape_Equilibrium
{
  //codility code starts here
  class Solution
  {
    public int solution(int[] A)
    {
      int left_part = A[0];
      int sum_all = A.Sum();
      int min_diff = Math.Abs((2*left_part) - sum_all); //left- right = left - (all-left) = left-all+left = 2*left - all
      for (int i = 1; i < (A.Length-1); i++)
			{
          left_part += A[i];
          min_diff = Math.Min(min_diff, Math.Abs((2*left_part) - sum_all));
			}
      return min_diff;
    }
  }
  //codility code ends here
  
  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();
      Console.WriteLine(sol.solution(new int[5] { 3, 1, 2, 4, 3})); // 1

      Console.ReadKey();
    }
  }
}
