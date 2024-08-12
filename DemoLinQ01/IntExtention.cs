using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinQ01
{
    internal static class IntExtention
    {
        //12345
        //54321
        //public static int Reverse<T>(this T Number)where T: IComparable
        //{
        //    int ReversedNum = 0, LastDigit;
        //    while (Number.CompareTo( 0)>0)
        //    {
        //        LastDigit 
        //        ReversedNum = ReversedNum * 10 + LastDigit;
        //        Number = Number / 10;

        //    }
        //    return ReversedNum;

        //}
        public static int Reverse(this int Number)
        {
            int ReversedNum = 0, LastDigit;
            while (Number > 0)
            {
                LastDigit = Number % 10;
                ReversedNum = ReversedNum * 10 + LastDigit;
                Number = Number / 10;

            }
            return ReversedNum;

        }
        public static long Reverse(this long Number)
        {
            long ReversedNum = 0, LastDigit;
            while (Number > 0)
            {
                LastDigit = Number % 10;
                ReversedNum = ReversedNum * 10 + LastDigit;
                Number = Number / 10;

            }
            return ReversedNum;

        }
        public static double Reverse(this double Number)
        {
            double ReversedNum = 0, LastDigit;
            while (Number > 0)
            {
                LastDigit = Number % 10;
                ReversedNum = ReversedNum * 10 + LastDigit;
                Number = Number / 10;

            }
            return ReversedNum;

        }
    }
}
