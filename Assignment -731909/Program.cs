using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateAndEvents
{
    class Program
    {
        
            //Name 1 - Inderjeet Singh
            //ID - c0731909

            //NAME 2 - Jagroop Singh
            //Id - C0730507


        

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
                myDelegate();
            }
        }
    }
}
