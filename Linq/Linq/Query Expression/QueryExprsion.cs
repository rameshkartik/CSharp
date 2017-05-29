using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Query_Expression
{
    public class QueryExprsion
    {
        public void Create()
        {
            string[] names = { "Rameshkartik", "Ranjith", "Ravi", "Rakesh" };

            IEnumerable<string> filtered =
                from n in names
                where n.Contains("a")
                orderby n.Length
                select n.ToUpper();

            foreach (string str in filtered)
            {
                Console.WriteLine(str);
            }
        }

        public void MixingQueryandFluentSyntax()
        {
            string[] names = { "Rameshkartik", "Ranjith", "Ravi", "Rakesh" };

            int matchesCount = (from n in names where n.Contains("k") select n).Count();
            Console.WriteLine("Matched Count: {0}", matchesCount.ToString());
            string firstEle = (from n in names orderby n select n).First();
            Console.WriteLine("First Data :{0}", firstEle.ToString());
        }
    }
}
