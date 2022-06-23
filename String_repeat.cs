using System.Linq;
namespace Solution

{
    public static class Program
    {
        public static string RepeatStr(int n, string s)
        {
            var result = string.Join("", Enumerable.Repeat(s, n));
            return result;
        }
    }
}