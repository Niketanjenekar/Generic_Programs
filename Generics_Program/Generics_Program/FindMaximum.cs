using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Program
{
    public class FindMaximum
    {
        public void FindingMaximum(int a, int b, int c)
        {
            if(a.CompareTo(b) > 0  && a.CompareTo(c) >0)
            {
                Console.WriteLine("The First Value " + a + "  is The Greatest Value");
            }
            else if(b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                Console.WriteLine("The Second Value " + b + "  is Greatest Value");
            }
            else
            {
                Console.WriteLine("The Third Value " + c + "  is the Greatest Value");
            }
        }
    }
}
