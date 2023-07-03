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

            Console.WriteLine("1. Find the Maximum Number Between Three Integers");
            int option = Convert.ToInt32(Console.ReadLine());

            FindMaximum findMaximum = new FindMaximum();
            switch (option)
            {
                case 1:
                    findMaximum.FindingMaximum(25, 99, 45);
                    break;

            }
            Console.ReadLine();
        }
    }
}
