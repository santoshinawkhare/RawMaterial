using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class GenericEx
    {
        public void intMaximum(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("Maximum No is :" + first);
            }
            if (second.CompareTo(third) > 0 && second.CompareTo(first) > 0)
            {
                Console.WriteLine("Maximum No is :" + second);
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("Maximum No is :" + third);
            }
        }
    }
}
