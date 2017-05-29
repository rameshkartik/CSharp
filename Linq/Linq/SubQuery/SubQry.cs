using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.SubQuery
{
    public class SubQry
    {
        public void SubQuerySample()
        {
            var list = new List<string>();
            list.Add("Ramesh Kartik");
            list.Add("Sachin Tendulkar");
            list.Add("Harshan Ramesh");
            IEnumerable<string> orderedlist =  list.Where(p => p.Length == list.OrderBy(p2 => p2.Length).Select(p2 => p2.Length).Last());
            foreach (string name in orderedlist)
            {
                Console.WriteLine(name);
            }

        }
    }
}
