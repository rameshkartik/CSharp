using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.BasicQueryOperator
{
    public class Operators
    {
        public void Ordering()
        {
            string[] names = { "Rameshkartik", "Kiruthika", "Harshan","Pradeep","Vijay" };
            IEnumerable<string> ThreeElem = names.Take<string>(2);
            Console.WriteLine("Take The First 2 Elements from Array..");
            foreach (var Iter in ThreeElem)
            {
                Console.WriteLine(Iter);
            }

            IEnumerable<string> ThreeElem_Skip = names.Skip<string>(3);
            Console.WriteLine("Skip The First 3 Elements from Array..");
            foreach (var Iter in ThreeElem_Skip)
            {
                Console.WriteLine(Iter);
            }

            IEnumerable<string> names_Reverse = names.Reverse<string>();
            Console.WriteLine("Reverse The Elements in Array..");
            foreach (var Iter in names_Reverse)
            {
                Console.WriteLine(Iter);
            }
            string str_First = names.First<string>();
            string str_Last = names.Last<string>();
            string str_Ele = names.ElementAt<string>(1);
            string first = names.OrderBy(n => n.Length).Skip(1).First();
            Console.WriteLine("First String: {0} Last String: {1} Element At 1:{2} Skipped Num: {3}",str_First,str_Last,str_Ele,first);

        }
    }
}
