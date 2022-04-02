using System;

namespace ValueAndReferenceTypes
{
    public class ReferenceType
    {
        public int X { get; set; }

        public int Y { get; set; }

        public ReferenceType()
        {

        }

        public ReferenceType(int x,int y)
        {
            X = x;
            Y = y;
        }

        public void SwapByRef(ref int x,ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        public void CheckOutKeyWordByRef(out int variable)
        {
            variable = 100;
            return;
        }
    }
}
