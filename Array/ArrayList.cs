using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays.Array
{
    public class ArrayList : DataStructures.Arrays.Array.Array, IEnumerable
    {
        private int position;
        public int Count => position;

        public ArrayList(int defaultSize):base(defaultSize)
        {
            position = 0;
        }

        public ArrayList()
        {

        }

        public ArrayList(IEnumerable collection):this()
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Add(Object value)
        {
            if (position == Length)
                DoubleArray();

            if(position < Length)
            {
                InnerArr[position] = value;
                //SetValue(value,position);
                position++;
                return;
            }
            throw new Exception();
        }

        public Object Remove()
        {
            if (position >= 0)
            {
                var temp = InnerArr[position - 1];
                position--;
                if (position == InnerArr.Length / 4)
                {
                    HalfArray();
                    return temp;
                }
            }
            throw new Exception();
        }

        private void DoubleArray()
        {
            try
            {
                var temp = new Object[InnerArr.Length * 2];
                System.Array.Copy(InnerArr,temp,InnerArr.Length);
                InnerArr = temp;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void HalfArray()
        {
            try
            {
                var temp = new Object[InnerArr.Length / 2];
                System.Array.Copy(InnerArr,temp,InnerArr.Length /2);
                InnerArr = temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        new public IEnumerator GetEnumerator()
        {
            return InnerArr.Take(position).GetEnumerator();
        }

    }
}
