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

        private bool CheckNumVal(uint num, uint lastNum)
        {
            if(num < lastNum) return false;
            if(num <= UInt32.MaxValue) return true;
        }


        public uint GetMinVal()
        {
            string minVal = "";
            uint lastNum;
            foreach(var num in _numList)
            {
                if(minVal == "") lastNum = 0;
                minVal += num.ToString();

                if(!CheckNumVal((uint)minVal, lastNum)) throw new Exception("Liczba minimalna utworzona z podanego ciągu nie mieści się w typie uint.");
            }
            return (uint)minVal;
        }

        public uint GetMaxVal()
        {
            string maxVal = "";
            uint lastNum;

            for(int i = _numList.Count; i > 0; i--)
            {
                if(maxVal == "") lastNum = 0;
                maxVal += _numList[i].ToString();

                if(!CheckNumVal((uint)minVal, lastNum)) throw new Exception("Liczba maksymalna utworzona z podanego ciągu nie mieści się w typie uint.");
            }
            return (uint)maxVal;            
        }
    }
}
