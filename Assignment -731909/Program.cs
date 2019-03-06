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







    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }

    }
    public delegate void MyDelegate();

    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }
    }

}