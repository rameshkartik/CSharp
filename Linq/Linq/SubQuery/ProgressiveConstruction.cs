using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.SubQuery
{
    public class ProgressiveConstruction
    {
        public void Qry()
        {
            var list = new List<string>();
            list.Add("Rameshkartik");
            list.Add("Harshan");
            list.Add("Thams");

            var containz = list.Where(p => p.Contains("m"));
            var sorted = containz.OrderBy(p => p.Length);
            var capsresult = sorted.Select(n => n.ToUpper());

            foreach (string name in capsresult)
            {
                Console.WriteLine(name);
            }
            
       
        }
    }
}
