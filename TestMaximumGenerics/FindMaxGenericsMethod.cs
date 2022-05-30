using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximumGenerics
{
    internal class FindMaxGenericsMethod
    {
        // Method to Find Max String Value
        public T FindMaxGeneric<T>(T Value1, T Value2, T Value3) where T: IComparable
        {
            // Use CompareTO Comparision B/W Three String Value
            if (Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) > 0)
            {
                return Value1; //Return The Greater String Value
            }
            if (Value2.CompareTo(Value1) > 0 && Value2.CompareTo(Value3) > 0)
            {
                return Value2;
            }
            if (Value3.CompareTo(Value1) > 0 && Value3.CompareTo(Value2) > 0)
            {
                return Value3;
            }
            return Value1; // Return While All Among Three are Equal

        }
    }
}
