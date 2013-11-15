using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_Binary_gap
{
  //codility code starts here
  class Solution
  {
    public int solution(int N) 
    {
      //this solution needs => using System.Collections.Generic;
      string binary = Convert.ToString(N, 2);
      for (int i = (binary.Length-2); i > 0; i--)
      {
        if (binary.Contains('1'+new String('0', i)+'1'))
        {
          return i;
        }
      }

      return 0;
    }
  }
  //codility code ends here    

  class Program
  {
    static void Main(string[] args)
    {
      Solution sol = new Solution();
      Console.WriteLine(sol.solution(529));//4
      Console.WriteLine(sol.solution(20));//1
      Console.WriteLine(sol.solution(1));//0
      Console.WriteLine(sol.solution(1041));//5

      Console.ReadKey();
    }
  }
}
