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
        public delegate int MyDelegate(int intvalue);
            public int Method1(int intMethod1)
            {
            return intMethod1 * 2;
            }
            public int Method2(int intMethod2)
            {
                return int intMethod2 * 10;
            }
        public voidMethod3()
        { 
        MyDelegate myDelegate = new MyDelegate(Method1);
        int result1 = myDelegate(10);
        System.Console.WriteLine(result1);
      myDelegate = new MyDelegate(Method2);
        int result2 = myDelegate(10);
        System.Console.WriteLine(result2);
    }
        static void Main(string[] args)
        {
            DelegateExcercises a = new DelegateExcercises();
            a.Method3();

        }
    }
    
        
    



