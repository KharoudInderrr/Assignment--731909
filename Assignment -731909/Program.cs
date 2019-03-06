using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Student name - Inderjeet Singh   Student id - C0731909

//Student name - jagroop Singh   Student id - C0730507

    // Assignment 2
    // March 6, 2019


namespace delegateAndEvents
{
       
            


        

        public class DelegateExcercises
        {
            public delegate void MyDelegate();
            void Method1()
            {
                Console.WriteLine("Method 1");
                Console.ReadLine();
            }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate(50);
            }
        }
    }




namespace delegateAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateExcercises a = new DelegateExcercises();
            a.Method2();
        }
    }
    
}
