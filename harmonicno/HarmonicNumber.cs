using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmonicno
{
    internal class HarmonicNumber
    {
        public void PrintHarmonicNo()

        {
            Console.WriteLine("Enter the N to Find the Nth Value Harmonic Number");
            int N = Convert.ToInt32(Console.ReadLine());
            float HarmonicNo = 0;
            if (N > 0)
            {
                for (float i = 1; i <= N; i++)
                {
                    HarmonicNo =HarmonicNo+ 1 / i;
                }
                Console.WriteLine("{0}th Harmonic Numberis : {1}", N, HarmonicNo);

            }
            else
            {
                Console.WriteLine("Please Enter Positive No");
            }
        }
    }
}
