using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.BasicQuery ;
using Linq.CQuery;
using Linq.BasicQueryOperator;
using Linq.Query_Expression;
using Linq.Deferred_Execution;
using Linq.SubQuery;
using Linq.Object_Initializer;
using Linq.Anonymous_Types;
namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Press the following Keys to launch the sample");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1 - BasicQueryUsingLinq");
            Console.WriteLine("2 - ChainQuery");
            Console.WriteLine("3 - Ordering");
            Console.WriteLine("4 - QueryExpression");
            Console.WriteLine("5 - Deffered Execution");
            Console.WriteLine("6 - Sub Query");
            Console.WriteLine("7 - Object Initializer");
            Console.WriteLine("8 - Anonymous Types");
            Console.WriteLine("----------------------------------------------");
            string str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Console.WriteLine("You Pressed :1 - BasicQueryUsingLinq");
                    Console.WriteLine("----------------------------------------------");
                    BasicQueryUsingLinq();
                    break;

                case"2":
                    Console.WriteLine("You Pressed :2 - ChainQuery");
                    Console.WriteLine("----------------------------------------------");
                    ChainQuery();
                    break;
                case"3":
                    Console.WriteLine("You Pressed :3 - Ordering");
                    Console.WriteLine("----------------------------------------------");
                    Ordering();
                    break;
                case "4":
                    Console.WriteLine("You Pressed :4 - Query Expression");
                    Console.WriteLine("----------------------------------------------");
                    QueryExpression();
                    break;
                case "5":
                    Console.WriteLine("You Pressed :5 - Deffered Execution");
                    Console.WriteLine("----------------------------------------------");
                    DefferedExec();
                    break;
                case "6":
                    Console.WriteLine("You Pressed :6 - Sub Query");
                    Console.WriteLine("----------------------------------------------");
                    SubQury();
                    break;
                case "7":
                    Console.WriteLine("You Pressed :7 - Object Initializer");
                    Console.WriteLine("----------------------------------------------");
                    ObjectInitializer();
                    break;
                case "8":
                    Console.WriteLine("You Pressed :8 - Anonymous Types");
                    Console.WriteLine("----------------------------------------------");
                    Anonymous_Types();
                    break;

            }
            Console.WriteLine("-------------------------------------------");
            Console.ReadKey();
        }

        static void BasicQueryUsingLinq()
        {
            BasicQuery.BasicQuery BQ = new BasicQuery.BasicQuery();
            BQ.BasicQueryUsingLinq();
            BQ.CallingWhereDirectly_FromArray();
            
        }

        static void ChainQuery()
        {
            ChainingQuery CQ = new ChainingQuery();
            CQ.ChainQuery();
            CQ.ChainQuery_NormalWay_UsingExtension();
            CQ.ChainQuery_NormalWay_WithoutExtension();

        }

        static void Ordering()
        {
            Operators Oprs = new Operators();
            Oprs.Ordering();
        }

        static void QueryExpression()
        {
            QueryExprsion QE = new QueryExprsion();
            QE.Create();
            QE.MixingQueryandFluentSyntax();
        }

        static void DefferedExec()
        {
            DefferedExec QE = new DefferedExec();
            QE.Create();
            QE.ReEvaluation();
            QE.DefeatRevaluation();
            QE.CapturedVariables();
            QE.DefferedExecution_AnotherSample();
            QE.ImmediateExectution();
            QE.DeferredExecution_EmplyeeSample();
        }

        static void SubQury()
        {
            SubQry SQ = new SubQry();
            SQ.SubQuerySample();

            ProgressiveConstruction PC = new ProgressiveConstruction();
            PC.Qry();
        }   

        static void ObjectInitializer()
        {
            ObjInitializer obj = new ObjInitializer();
            obj.ObjQuery();
            obj.EmployeeCollectionQuery();
        }

        static void Anonymous_Types()
        {
            AType at = new AType();
            at.Func();
        }
    }
}
