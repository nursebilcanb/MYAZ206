﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Generic
{
    public class Array<T> : ICloneable, IEnumerable<T>
    {
        private T[] InnerArray { get; set; }

        public int Length => InnerArray.Length;
        
        private int position;
        
        public int Count => position;

        public Array(int defaultSize = 15)
        {
            InnerArray = new T[defaultSize];
        }

        public Array(params T[] sourceArray) : this(sourceArray.Length)
        {
            System.Array.Copy(sourceArray, InnerArray, sourceArray.Length);
        }

        public Array(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public T GetValue(int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException();
            return InnerArray[index];
        }

        public void SetValue(T value, int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException();

            if (value == null)
                throw new ArgumentNullException();
           
            InnerArray[index] = value;
        }

        public void Add(T value)
        {
            if (position == Length)
                DoubleArray();

            if (position < Length)
            {
                InnerArray[position] = value;
                position++;
                return;
            }
            throw new Exception();
        }

        public T Remove()
        {
            if (position >= 0)
            {
                var temp = InnerArray[position - 1];
                position--;
                if (position == InnerArray.Length / 4)
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
                var temp = new T[InnerArray.Length * 2];
                System.Array.Copy(InnerArray,temp,InnerArray.Length);
                InnerArray = temp;
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
                var temp = new T[InnerArray.Length / 2];
                System.Array.Copy(InnerArray,temp,InnerArray.Length);
                InnerArray = temp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < InnerArray.Length; i++)
            {
                if (GetValue(i).Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ArrayEnumerator<T>(InnerArray);
            //foreach (T item in this._innerArray)
            //{
            //    yield return item;
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
