using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
   public class DateCaliculator
   {
       private static readonly int[] DaysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //number of days for eatch month for 12 months

       public int CaliculateDays(int iFromday, int iFromMonth, int iFromYear, int iToday, int iToMonth, int iToyear)
       {
            //Set February days based on year, if Leap year then 29 else get from static variable "DaysPerMonth" value of February i.e 28
            var iDifference = (iFromMonth == 2 && LeapYearCheck(iFromYear))? 29 - iFromday: DaysPerMonth[iFromMonth] - iFromday;
            
            //if same year and month then just get date difference 
            if (iFromYear == iToyear && iFromMonth == iToMonth)
                return Math.Abs(iFromday - iToday);
            
           var i = iFromMonth + 1;

            while (true)
            {
                while (i <= 12)
                {
                    
                    if (iFromYear == iToyear && i == iToMonth) //calculation over since both years same
                    {
                        iDifference += iToday;//inlcude given desination month days too
                        return iDifference;
                    }

                    iDifference += (i == 2 && LeapYearCheck(iFromYear))?  29: DaysPerMonth[i];//Assign days in loop
                    i++;
                }
                i = 1;// set to 1 to loop month days for eatch year
                iFromYear++;// increment year till it reach desination year
            }
        }

       private bool LeapYearCheck(int iYear)
       {
           return (iYear % 4 == 0 || iYear % 100 == 0) && iYear % 400 != 0;// find input year is leapYear
       }
        public int Test(int iFromday, int iFromMonth, int iFromYear, int iToday, int iToMonth, int iToyear)
        {
            int iResult = 0;
            //input Date order can be ascending or descending
            if (iFromYear > iToyear || iFromMonth > iToMonth)
                iResult= CaliculateDays(iToday, iToMonth, iToyear, iFromday, iFromMonth, iFromYear);
            else 
                iResult=CaliculateDays(iFromday, iFromMonth, iFromYear, iToday, iToMonth, iToyear);
            
            return iResult;
        }


    }
}
