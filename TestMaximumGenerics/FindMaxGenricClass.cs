using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximumGenerics
{
    // Defining Generic Class
    internal class FindMaxGenricClass<T> where T : IComparable
    {
        // instance generic variable
        T Value1, Value2, Value3;


        // Defining Parameterized Constructor..
        public FindMaxGenricClass(T Value1,T Value2,T Value3)
        {
            this.Value1 = Value1;
            this.Value2 = Value2;
            this.Value3 = Value3;
        }

        public static T FindMaxAmong3(T Value1, T Value2, T Value3)
        {
            // Use CompareTO Comparision B/W  Value
            if (Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) > 0)
            {
                return Value1; //Return The Greater  Value
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

        // instance method to pass instance generic Variable
        public T TestMaxValue()
        {
            T testmax = FindMaxGenricClass<T>.FindMaxAmong3(this.Value1, this.Value2, this.Value3);
            return testmax;
        }
    }
}
