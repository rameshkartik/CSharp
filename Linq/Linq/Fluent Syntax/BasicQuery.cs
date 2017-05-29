using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.BasicQuery
{
    public class BasicQuery
    {
        public void BasicQueryUsingLinq()
        {
            string[] names = { "Ramesh", "Kartik", "Harshan", "Kiru" };
            IEnumerable<string> strFilteredNames = 
                System.Linq.Enumerable.Where(names, n => n.Length > 4);
            Console.WriteLine("OutputNames Greater than Length 4 :");
            foreach (string str in strFilteredNames)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Output Names Lesser than Length 4 :");
            IEnumerable<string> strFilteredNames_Lesser =
                System.Linq.Enumerable.Where(names, n => n.Length <= 4);

            foreach (string str in strFilteredNames_Lesser)
            {
                Console.WriteLine(str);
            }
        }

        public void CallingWhereDirectly_FromArray()
        {
            string[] names = { "Ramesh", "Kartik", "Harshan", "Kir" };
            var Filtered = names.Where<string>(n => n.Length > 3);

            Console.WriteLine("OutputNames Greater than Length 3 :");
            foreach (string str in Filtered)
            {
                Console.WriteLine(str);
            }
        }
    }
}
