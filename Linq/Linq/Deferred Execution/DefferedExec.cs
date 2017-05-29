using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Deferred_Execution
{

    public class Employee
    {
        private int empNo;
        public int EmployeeNo
        {
            get
            {
                return empNo;
            }
            set
            {
                empNo = value;
            }
        }

        private int empAge;
        public int EmployeeAge
        {
            get
            {
                return empAge;
            }
            set
            {
                empAge = value;
            }
        }


        private string empName;
        public string EmployeeName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }
    }
    
    public class DefferedExec
    {
        public void Create()
        {
            var numbers = new List<int>();
            numbers.Add(1);

            IEnumerable<int> Qry =  numbers.Select(n => n * 10);
            numbers.Add(2);

            foreach (int i in Qry)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void ReEvaluation()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);

            IEnumerable<int> qry = list.Select(n => n * 10);
            foreach (int i in qry)
            {
                Console.WriteLine(i.ToString());
            }

            list.Clear();
            if (qry.Count() < 1)
            {
                Console.WriteLine("Query Empty");
            }
            
            
        }

        public void DefeatRevaluation()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);

            IEnumerable<int> qry = list.Select(n => n * 10).ToList() ;
            list.Clear();

            foreach (int i in qry)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void CapturedVariables()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            var val = 20;
            IEnumerable<int> qry = list.Select(n => n * val).ToList();
            list.Clear();
            val = 40;
            foreach (int i in qry)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void DefferedExecution_AnotherSample()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var query = from lst in list
                        where lst > 2
                        select new { lst };

            list.Add(5);
            foreach (var v in query)
            {
                Console.WriteLine(v.ToString());
            }

        }

        public void ImmediateExectution()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var query = (from lst in list
                         where lst > 2
                         select lst).Count();

            list.Add(5);
            Console.WriteLine("Count :"+ query.ToString());

        }

        public void DeferredExecution_EmplyeeSample()
        {
            var emp_list = new List<Employee>(
            new Employee[] 
            {
                new Employee {EmployeeAge =29,EmployeeName="Ram",EmployeeNo=1234},
                new Employee {EmployeeAge = 30,EmployeeName="Ravi", EmployeeNo= 124},
                new Employee {EmployeeAge = 40,EmployeeName ="Raja",EmployeeNo = 1245}
                
            });

            var emp_list_query = from e in emp_list
                           where e.EmployeeAge > 30
                           select new { e.EmployeeName };
            emp_list.Add(new Employee { EmployeeAge = 52, EmployeeName = "Siva", EmployeeNo = 122 });


            foreach (var emp in emp_list_query)
            {
                Console.WriteLine(emp.EmployeeName);
            }
              
        }

    }

}
