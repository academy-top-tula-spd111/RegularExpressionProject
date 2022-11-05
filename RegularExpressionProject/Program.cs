using System.Text.RegularExpressions;

namespace RegularExpressionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "aaaaaaa bbbbbb aabbss fffdddaaa";

            // (111) 123-45-67
            Regex regex = new Regex(@"(^\w*|\s+|^)a{2}\w*");  //(@"\(\d{3}\)\s*\d{3}-\d{2}-\d{2}");

            //if (regex.IsMatch(str))
            //    Console.WriteLine("phone!");
            //else
            //    Console.WriteLine("not phone!");

            MatchCollection matches = regex.Matches(str);

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }


            //string strRepl = regex.Replace(str, "qq");
            //Console.WriteLine(strRepl);
        }
    }
}