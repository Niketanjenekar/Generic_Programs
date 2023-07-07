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

            FindMaximum<int> intMax = new FindMaximum<int>();            
            int maxVal = intMax.FindingMaximum(2, 5, 7);
            Console.WriteLine("The Maximum Value " + maxVal + "  is The Greatest Integer Value");

            Console.WriteLine("*********************************");

            FindMaximum<string> stringMax = new FindMaximum<string>();
            string maxString = stringMax.FindingMaximum("apple" , "mango" , "peach");
            Console.WriteLine("The Maximum Value " + maxString + "  is The Greatest String");
            
            Console.WriteLine("*********************************");
            
            FindMaximum<double> doubleMax = new FindMaximum<double>();
            double maxDouble = doubleMax.FindingMaximum(1.2, 3.5, 5.45);
            Console.WriteLine("The Maximum Value " + maxDouble + "  is The Greatest Double Value");
            
            Console.WriteLine("*********************************");

            Console.ReadLine();
        }
    }
}
