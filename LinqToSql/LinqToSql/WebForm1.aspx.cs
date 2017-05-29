using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqToSql
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetMethod();
        }

        private void GetMethod()
        {
            DataClasses1DataContext Dbcntxt = new DataClasses1DataContext();
            GridView1.DataSource = from emp in Dbcntxt.Employees
                                   where emp.Job == "Clerk"
                                   orderby (emp.EmpNo) ascending
                                   select emp;


            GridView1.DataBind();
        }

        protected void btn_Get_Click(object sender, EventArgs e)
        {
            GetMethod();
        }

        protected void btn_Insert_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dcnt = new DataClasses1DataContext())
            {
                Employee emp = new Employee()
                {
                    EmpNo = 101,
                    EmpName = "Rameshkartik",
                    Comm = 1500,
                    DEPTNO = 10,
                    Hiredate = Convert.ToDateTime("1980-12-17"),
                    Job = "Clerk",
                    Mgr = 10,
                    Sal = 15000
                };
                dcnt.Employees.InsertOnSubmit(emp);
                dcnt.SubmitChanges();
                
            }
            GetMethod();
        }



        
    }
}