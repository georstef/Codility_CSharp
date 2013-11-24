using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_Max_Counters
{
  //codility code starts here
  class Solution
  {
    public int[] solution(int N, int[] A)
    {
      int[] result = new int[N];
      int min_value = 0;
      int max_counter = 0;
      foreach (int item in A)
      {
        if (item <= N)
        {
          result[item - 1] = Math.Max(result[item - 1], min_value);
          result[item - 1] += 1;
          max_counter = Math.Max(result[item - 1], max_counter);
        }
        else
        {
          min_value = max_counter;
        }
      }
      for (int i = 0; i < N; i++)
      {
        result[i] = Math.Max(result[i], min_value);
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

      int[] answer = sol.solution(5, new int[7] { 3, 4, 4, 6, 1, 4, 4 });// [3, 2, 2, 4, 2]
      for (int i = 0; i < answer.Length; i++)
      {
        Console.Write(answer[i].ToString() + ' ');
      }

      Console.ReadKey();
    }
  }
}
