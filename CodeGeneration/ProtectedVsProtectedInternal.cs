using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
   public class ProtectedVsProtectedInternal
    {
        
        protected string getDay()
        {
            return DateTime.Now.DayOfWeek.ToString();
        }

        protected internal string GetMonth()
        {
            return DateTime.Now.Month.ToString();
        }
    }

    public class ProtectedTest: ProtectedVsProtectedInternal
    {
        ProtectedVsProtectedInternal pi=new ProtectedVsProtectedInternal();
        public void print()
        {
            getDay();
            pi.GetMonth();
            GetMonth();
        }

        
    }
}
