using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciple
{
    /*
    
        Let's say the Select method in the EmployeeDB1 class is used by two clients/screens. One is made for normal employees, 
        one is made for managers, and the Manager Screen needs a change in the method.

        If I make changes in the Select method to satisfy the new requirement, 
        other UI will also be affected. Plus making changes in existing tested solution may result in unexpected errors.
        
     *
     * What is OCP?     Software modules should be closed for modifications but open for extensions.

     */
    class OpenClosePrinciple
    {
        public OpenClosePrinciple()
        {
            //Normal Screen
            EmployeeDb1 objEmpDb = new EmployeeDb1();
            Employee objEmp = objEmpDb.Select();

            //Manager Screen
            EmployeeDb1 objEmpDb1 = new EmployeeManagerDb();
            Employee objEmp1 = objEmpDb1.Select();
        }
    }

    public class EmployeeDb1
    {
        public virtual Employee Select()
        {
            //Old Select Method
            return new Employee();
        }
    }
    public class EmployeeManagerDb : EmployeeDb1
    {
        public override Employee Select()
        {
            //Select method as per Manager
            //UI requirement
            return new Employee();
        }
    }
}
