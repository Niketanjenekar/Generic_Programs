using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Program
{
    public class FindMaximum<T> where T : System.IComparable<T>
    {
        private T firstVal;
        private T secondVal;
        private T thirdVal;

        public FindMaximum(T firstVal, T secondVal, T thirdVal)
        {
            this.firstVal = firstVal;
            this.secondVal = secondVal;
            this.thirdVal = thirdVal;
        }
        public T FindMax()
        {
            return FindMaximum<T>.FindingMaximum(firstVal, secondVal, thirdVal);
        }

        public static T FindingMaximum(T firstVal, T secondVal, T thirdVal)
        {
            T maxVal = firstVal;
            if(maxVal.CompareTo(secondVal) > 0  && maxVal.CompareTo(thirdVal) > 0)
            {
                return maxVal;
            }
            else if(secondVal.CompareTo(maxVal) > 0 && secondVal.CompareTo(thirdVal) > 0)
            {
                maxVal = secondVal;
            }
            else
            {
                maxVal = thirdVal;
            }
            return maxVal;
            
        }
        

        
    }
}
