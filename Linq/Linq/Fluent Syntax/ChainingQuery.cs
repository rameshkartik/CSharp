using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.CQuery
{
    public class ChainingQuery
    {
        public void ChainQuery()
        {
            string[] names = { "RameshKartik", "Harshan", "Kiru", "Pradeep" };
            var query = names
                .Where(n => n.Contains("a"))
                .OrderBy(n => n.Length)
                .Select(n => n.ToUpper());

            foreach (string str in query)
            {
                Console.WriteLine(str);
            }
        }

        public void ChainQuery_NormalWay_UsingExtension()
        {
            string[] names = { "RameshKartik", "Harshan", "Kiru", "Pradeep" };
            IEnumerable<string> filtered_ContainsA = names.Where<string>(n => n.Contains("a"));
            IEnumerable<string> ordered = filtered_ContainsA.OrderBy(n => n.Length);
            IEnumerable<string> final_UpperCase = ordered.Select(n => n.ToUpper());
        }

        public void ChainQuery_NormalWay_WithoutExtension()
        {
            string[] names = { "RameshKartik", "Harshan", "Kiru", "Pradeep" };
            IEnumerable<string> filtered_ContainsA = Enumerable.Where<string>(names,n => n.Contains("a"));
            IEnumerable<string> ordered = Enumerable.OrderBy(filtered_ContainsA, n => n.Length);
            IEnumerable<string> final_UpperCase = Enumerable.Select(ordered,n => n.ToUpper());
        }
    }
}
