using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SOLIDPrinciple
{
    class SingleResponsibilityPrinciple
    {
    }
    /*
     *
     *
     *
     * What is the issue?
Every time one gets changed there is a chance that the other also gets changed because both are staying in the same home and both have same parent. We can’t control everything. So a single change leads to double testing (or maybe more).

What is SRP?
SRP says "Every software module should have only one reason to change".

Software Module – Class, Function etc.
Reason to change - Responsibility
Solutions which will not Violate SRP
Now it’s up to us how we achieve this. One thing we can do is create three different classes

Employee – Contains Properties (Data)
EmployeeDB – Does database operations
EmplyeeReport – Does report related tasks


     */
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeNo { get; set; }
    }

    public class EmployeeDB
    {
        ////Method with multiple responsibilities – violating SRP
        //public void Insert(Employee e)
        //{
        //    string StrConnectionString = "";
        //    SqlConnection objCon = new SqlConnection(StrConnectionString);
        //    SqlParameter[] someParameters = null;
        //    SqlCommand objCommand = new SqlCommand("InertQuery", objCon);
        //    objCommand.Parameters.AddRange(someParameters);
        //    objCommand.ExecuteNonQuery();
        //}

        //Method with single responsibility – follow SRP
        public void Insert(Employee e)
        {
            SqlConnection objCon = GetConnection();
            SqlParameter[] someParameters = GetParaeters();
            SqlCommand objCommand = GetCommand(objCon, "InertQuery", someParameters);
            objCommand.ExecuteNonQuery();
        }

        private SqlParameter[] GetParaeters()
        {
            return new SqlParameter[1];
        }

        private SqlConnection GetConnection()
        {
            string StrConnectionString = "";
            return new SqlConnection(StrConnectionString);
        }

        private SqlCommand GetCommand(SqlConnection objCon, string insertQuery, SqlParameter[] someParameters)
        {
            SqlCommand objCommand = new SqlCommand(insertQuery, objCon);
            objCommand.Parameters.AddRange(someParameters);
            return objCommand;
        }
    }
}
