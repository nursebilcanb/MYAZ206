using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    public class ValueType
    {
        public int X { get; set; }

        public int Y { get; set; }

        public ValueType(int x,int y)
        {
            X = x;
            Y = y;
        }
        public ValueType()
        {

        }

        public void SwapByValue(int x,int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        public void CheckOutKeyWordByValue(int variable)
        {
            variable = 100;
            return;
        }
    }
}
