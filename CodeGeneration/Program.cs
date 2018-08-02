using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Globalization;

namespace CodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList arr = new ArrayList();
            //ArrayList arr1 = new ArrayList();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    var code = CodeGeneration.GetUniqueKey(16);
            //    Console.WriteLine(code);
            //    arr.Add(code);
            //}
            //for (int i = 0; i < 10000000; i++)
            //{
            //    var code = CodeGeneration.GetUniqueKey(16);
            //    if (arr1.Contains(code))
            //    {
            //        Console.WriteLine(code);
            //    }
            //}


            //Console.ReadLine();


            return;
            //AccessModifier a1=new AccessModifier();


            /*   string sSource;
              string sLog;
              string sEvent;

              sSource = "dotNET Sample App";
              sLog = "Application";
              sEvent = "Sample Event";

              if (!EventLog.SourceExists(sSource))
                  EventLog.CreateEventSource(sSource, sLog);

              EventLog.WriteEntry(sSource, sEvent);
              EventLog.WriteEntry(sSource, sEvent,
              EventLogEntryType.Error, 234);*/

            /* Multi threaded singleton */
            // Parallel.Invoke(()=> PrintSudentDetails(),()=> PrintEmploeeDetails());



            /* Can we Create abstract Class constructor? */
            //Dog dValue = new Dog();
            //dValue.Speak();

            //Singleton.DerivedClass derived = new Singleton.DerivedClass();
            //derived.PrintDetails("test22");
            
            /*  Method hiding

            A b=new B();  // Calls A function with new key word
            //B b=new B(); // Calls B function
            //A b=new A();  // Calls B function
            b.Foo();

            */
            

            //Console.WriteLine("+++++++++++++++++++");

            //ClassA a = new ClassB();

            //a.Add();
            Console.ReadLine();

        }


        public static void test(string s, string s1)
        {

        }

        public static void test(int s, int s1)
        {

        }




        abstract class Animal
        {
            public string DefaultMessage { get; set; }

            public Animal()
            {
                Console.WriteLine("Animal constructor called");
                DefaultMessage = "Default Speak";
            }
            public virtual void Speak()
            {
                Console.WriteLine(DefaultMessage);
            }
        }

        class Dog : Animal
        {
            public Dog() : base()//base() redundant.  There's an implicit call to base here.
            {
                Console.WriteLine("Dog constructor called");
            }
            public override void Speak()
            {
                Console.WriteLine("Custom Speak");//append new behavior
                base.Speak();//Re-use base behavior too
            }
        }

        private static void PrintEmploeeDetails()
        {
            Singleton employee = Singleton.GetInstance;
            employee.PrintDetails("from employee");
        }

        private static void PrintSudentDetails()
        {
            Singleton student = Singleton.GetInstance;
            student.PrintDetails("from student");
        }


    }

   internal class ClassA
    {
        static ClassA()
        {

            Console.WriteLine("Static ClassA");
        }

        public ClassA()
        {
            Console.WriteLine("public ClassA");
        }

        public void Add()
        {
            Console.WriteLine("public ClassA virtual");
        }
    }

    internal class ClassB : ClassA
    {
        static ClassB()
        {

            Console.WriteLine("Static ClassB");
        }

        public ClassB()
        {
            Console.WriteLine("public ClassB");
        }

        //public new void Add()
        //{
        //    Console.WriteLine("public ClassA new");
        //}

        public virtual new void Add()
        {
            Console.WriteLine("public ClassA new");
        }
    }

    public class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("A function");
        }
    }

    public class B : A
    {
        public  void Foo()
        {
            Console.WriteLine("B function");
        }
    }

    public class DTVitem
    {
        private DateTime _datevalue;

        public string Dt
        {
            get => _datevalue.ToShortDateString();
            set => DateTime.TryParse(value, out _datevalue);
        }
    }


    public enum values
    {        
        FirstValue=1,        
        SecondValue=2,       
        ThirdValue=3
    }


}
