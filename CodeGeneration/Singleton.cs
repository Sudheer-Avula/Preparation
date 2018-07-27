using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration
{
    
    public sealed class Singleton
    {
        public static int iCounter;
       // private static readonly object obj = new object();
       private Singleton()
        {
            iCounter++;
            Console.WriteLine("Count :" + iCounter.ToString());
        }

        public static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());


        public static Singleton GetInstance
        {
            get
            {
                //if (instance == null)
                //{
                //    lock (obj)
                //    {
                //        if (instance == null)
                //            instance = new Singleton();
                       
                //    }
                //}
                return instance.Value;
            }
             
        }
        public void PrintDetails(string str)
        {
            Console.WriteLine(str);
        }

        //public class DerivedClass : Singleton
        //{

        //}

    }
}
