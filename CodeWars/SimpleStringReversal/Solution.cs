using System;
using System.Linq;

namespace CodeWars.SimpleStringReversal
{
    public class Solution
    {
        public static string solve(string s)
        {
          var spaceIndexes = s.Split(' ').Select(x=>x.Length).ToArray();

          var result = string.Empty;
          var reversed = string.Join("", s.Reverse().Where(x=>x.ToString() != " "));
          int acc = 0;
          foreach(var space in spaceIndexes){
            result += reversed.Substring(acc, space) + " ";
            acc += space;
          }
          Console.WriteLine(result);
          return result.Trim();
        }
    }
}