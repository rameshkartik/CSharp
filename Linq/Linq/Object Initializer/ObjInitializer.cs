using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Object_Initializer
{
    public class ObjInitializer
    {
        string[] names = { "Rameshkartik", "Thams", "Harshan" };

        public void ObjQuery()
        {
            IEnumerable<ObjectHolder> iter = from n in names
                                             select new ObjectHolder
                                             {
                                                 OriginalContent = n,
                                                 Vowelless= n.Replace("a","").Replace("e","").Replace("i","").Replace("o","").Replace("u","")
                                             };

            

            IEnumerable<string> iter_str = from item in iter
                                           where item.Vowelless.Length > 4
                                           select item.OriginalContent;

            foreach (string str in iter_str)
            {
                Console.WriteLine(str);
            }
        }

        public void EmployeeCollectionQuery()
        {
            var list = new List<Employee>() 
            {
                new Employee {EmployeeAge= 30, EmployeeName="RameshKartik",EmployeeNo=123},
                new Employee {EmployeeAge = 29,EmployeeName = "Karthik",EmployeeNo =124},
                new Employee{EmployeeAge=25, EmployeeName="Siva",EmployeeNo=125}
            };


            IEnumerable<EmployeeHolder> iter_Emp = from e in list
                                                   select new EmployeeHolder
                                                   {
                                                       emp_Original = e,
                                                       emp = new Employee { EmployeeAge = e.EmployeeAge, EmployeeNo = 334, EmployeeName = e.EmployeeName }
                                                   };

            IEnumerable<Employee> emp_query = from e in iter_Emp
                                                    where e.emp.EmployeeNo == 334
                                                    select e.emp_Original;

            foreach (Employee e in emp_query)
            {
                Console.WriteLine("Employee Age {0}", e.EmployeeAge);
                Console.WriteLine("Employee No {0}", e.EmployeeNo);
                Console.WriteLine("Employee Name {0}", e.EmployeeName);
            }
        
        }
    }

    public class ObjectHolder
    {
        public string OriginalContent;
        public string Vowelless;
    }

    public class EmployeeHolder
    {
        public Employee emp_Original;
        public Employee emp;
    }
    public class Employee
    {
        private int iEmpNo;
        public int EmployeeNo
        {
            get
            {
                return iEmpNo;
            }
            set
            {
                iEmpNo = value;
            }
        }

        private int iEmpAge;
        public int EmployeeAge
        {
            get
            {
                return iEmpAge;
            }
            set
            {
                iEmpAge = value;
            }
        }

        private string sStrEmployeeName;
        public string EmployeeName
        {
            get
            {
                return sStrEmployeeName;
            }
            set
            {
                sStrEmployeeName = value;
            }
        }
    }
}
