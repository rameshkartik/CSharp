using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Anonymous_Types
{
    public class AType
    {
        public void Func()
        {
            var list = new List<Employee>()
            {
                 new Employee {EmployeeAge= 30, EmployeeName="RameshKartik",EmployeeNo=123},
                new Employee {EmployeeAge = 29,EmployeeName = "Karthik",EmployeeNo =124},
                new Employee{EmployeeAge=25, EmployeeName="Siva",EmployeeNo=125}
            };

            var empLst_Iter = from em in list
                              select new
                              {
                                  Original = em,
                                  Changed = new Employee()
                                  {
                                      EmployeeAge = 60, EmployeeNo = em.EmployeeNo, EmployeeName = em.EmployeeName
                                  }
                              };

            IEnumerable<Employee> lstEmp = from ei in empLst_Iter
                                           where ei.Changed.EmployeeAge == 60
                                           select ei.Original;

            foreach (Employee e in lstEmp)
            {
                Console.WriteLine("Employee Age {0}", e.EmployeeAge);
                Console.WriteLine("Employee No {0}", e.EmployeeNo);
                Console.WriteLine("Employee Name {0}", e.EmployeeName);
            }

        }
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
