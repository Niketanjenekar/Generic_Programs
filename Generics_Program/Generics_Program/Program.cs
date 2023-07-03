using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("**************Welcome to Find Maximum Using Generics Problems**************");

            //******************************Day-13 Assignments******************************

            FindMaximum findMaximum = new FindMaximum();
            
            findMaximum.FindingMaximum(3.14f, 6.2f, 1.9f);

            Console.ReadLine();
        }
    }
}
