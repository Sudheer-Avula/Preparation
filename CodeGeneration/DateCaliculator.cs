using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
   public class DateCaliculator
   {
       private static readonly int[] DaysPerMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //number of days for eatch month for 12 months

       public DateCaliculator()
       {

       }

       public void CaliculateDays(int iFromday, int iFromMonth, int iFromYear, int iToday, int iToMonth, int iToyear)
        {
            int iDifference;
            var i = iFromday + 1;

            if (iFromMonth == 2 && (iFromYear % 4 == 0 || iFromYear % 100 == 0) && iFromYear % 400 != 0)
            {
                iDifference = 29 - iFromday;// if leap year decrease 1 day to so that equal to 28
            }
            else
            {
                iDifference = DaysPerMonth[iFromMonth] - iFromday;
            }
            //same month and same year simplify
            if (iFromYear == iToyear && iFromMonth == iToMonth)
            {
                Console.Write("The Difference is {0:D}", Math.Abs(iFromday - iToday));
                return;
            }
            if (i == 13)
            {
                i = 1;
            }
            CaliculateforDifferentYears(ref iFromYear, iToday, iToMonth, iToyear, ref iDifference, ref i);
        }

        private static int CaliculateforDifferentYears(ref int iFromYear, int iToday, int iToMonth, int iToyear, ref int iDifference, ref int i)
        {
            int iResult = 0;
            while (true)
            {
                while (i <= 12)
                {
                    if (iFromYear == iToyear && i == iToMonth) //calculation over since both years same
                    {
                        //and months too
                        iDifference += iToday;
                        return iDifference;
                        //Console.Write("The Difference is {0:D}", iDifference);
                        //return;
                    }
                    if (i == 2 && ((iFromYear % 4 == 0 || iFromYear % 100 == 0) && iFromYear % 400 != 0))
                    {
                        //leap year so count 29 days
                        iDifference += 29;
                    }
                    else
                    {
                        iDifference += DaysPerMonth[i];
                    }
                    i++;
                }
                i = 1;
                iFromYear++;
            }
        }

        public int Test(int iFromday, int iFromMonth, int iFromYear, int iToday, int iToMonth, int iToyear)
        {
            if (iFromYear > iToyear)
            {
                CaliculateDays(iToday, iToMonth, iToyear, iFromday, iFromMonth, iFromYear);
            }
            else if (iToyear > iFromYear)
            {
                CaliculateDays(iFromday, iFromMonth, iFromYear, iToday, iToMonth, iToyear);
            }
            else
            {
                if (iFromMonth > iToMonth)
                {
                    CaliculateDays(iToday, iToMonth, iToyear, iFromday, iFromMonth, iFromYear);
                }
                else
                {
                    CaliculateDays(iFromday, iFromMonth, iFromYear, iToday, iToMonth, iToyear);
                }
            }
            return 0;
        }


    }
}
