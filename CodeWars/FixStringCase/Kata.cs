using System.Linq;

namespace CodeWars.FixStringCase
{
    class Kata
    {
        public static string Solve(string s)
        {
            var upperCaseCount = s.Count(char.IsUpper);
            var lowerCaseCount = s.Count(char.IsLower);

            if (lowerCaseCount >= upperCaseCount) 
            {
                return s.ToLower();
            }
            else 
            {
                return s.ToUpper();
            }
        }
    }
}