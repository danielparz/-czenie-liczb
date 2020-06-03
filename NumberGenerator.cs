using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            return true;
        }


        public uint GetMinVal()
        {
            string minVal = "";
            uint lastNum;
            foreach(var num in _numList)
            {
                
                minVal += num.ToString();

                if(minVal == "") lastNum = 0;
                else lastNum = UInt32.Parse(minVal);

                if(!CheckNumVal(UInt32.Parse(minVal), lastNum)) throw new Exception("Liczba minimalna utworzona z podanego ciągu nie mieści się w typie uint.");
                
            }
            return UInt32.Parse(minVal);
        }

        public uint GetMaxVal()
        {
            string maxVal = "";
            uint lastNum;
            _numList.Reverse();

            foreach(var num in _numList)
            {                
                maxVal += num.ToString();

                if (maxVal == "") lastNum = 0;
                else lastNum = UInt32.Parse(maxVal);

                if (!CheckNumVal(UInt32.Parse(maxVal), lastNum)) throw new Exception("Liczba maksymalna utworzona z podanego ciągu nie mieści się w typie uint.");
            }
            return UInt32.Parse(maxVal);            
        }
    }
}
