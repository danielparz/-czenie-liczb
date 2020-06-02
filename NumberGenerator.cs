using System;
using System.Collections.Generic;
using System.Text;

namespace Łączenie_liczb
{
    class NumberGenerator
    {
        List<uint> _numList { get; set; }

        public NumberGenerator(uint[] numTab)
        {
            _numList = new List<uint>(numTab);
            _numList.Sort(new NumbersComparator());
        }


    }
}
