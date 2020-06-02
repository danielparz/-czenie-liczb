using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Łączenie_liczb
{
    class NumbersComparator : IComparer<uint>
    {
        public int Compare(uint x, uint y)
        {
            string strx = x.ToString();
            string stry = y.ToString();

            int shorter = (strx.Length < stry.Length) ? strx.Length : stry.Length;

            for (int i = 0; i < shorter; i++)
            {
                if ((int)strx[i].CompareTo((int)stry[i]) != 0)
                    return (int)strx[i].CompareTo((int)stry[i]);
            }
            return 0;
        }       
    }
}
