using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_Frog_Jmp
{
  //codility code starts here
  class Solution
  {
    public int solution(int X, int Y, int D)
    {
      return (Y - X + (D-1)) / (D);
    }
  }
  //codility code ends here
  
  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();
      Console.WriteLine(sol.solution(10, 85, 30)); // 3
      Console.WriteLine(sol.solution(10, 40, 30)); // 1
      Console.WriteLine(sol.solution(10, 41, 30)); // 2

      Console.ReadKey();
    }
  }
}
