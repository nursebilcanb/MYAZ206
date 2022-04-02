using System;
using System.Collections;

namespace DataStructures.Arrays.Array
{
    public class Array : ICloneable, IEnumerable
    {
        protected Object[] InnerArr { get; set; }

        public int Length => InnerArr.Length;

        public Array(int defaultSize = 16)
        {
            InnerArr = new Object[defaultSize];
        }

        public Array(params Object[] sourceArray) : this(sourceArray.Length)
        {
            System.Array.Copy(sourceArray, InnerArr, sourceArray.Length);
        }

        public void SetValue(Object value, int index)
        {
            if (!(index >= 0 && index < InnerArr.Length))
                throw new ArgumentOutOfRangeException();

            if (value == null)
                throw new ArgumentNullException();

            InnerArr[index] = value;
            return;
        }

        public Object GetValue(int index)
        {
            if (!(index >= 0 && index < InnerArr.Length))
                throw new ArgumentOutOfRangeException();
           
            return InnerArr[index];
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public IEnumerator GetEnumerator()
        {
            return InnerArr.GetEnumerator();
        }
        
        public int IndexOf(Object value)
        {
            for (int i = 0; i < InnerArr.Length; i++)
            {
                if (value.Equals(InnerArr[i])) // GetValue(i).Equals(valu)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
