﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BST<T> : IEnumerable<T>
        where T : IComparable
    {
        public Node<T> Root { get; set; }
        public BST()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        public void Add(T value)
        {
            if (value == null)
                throw new ArgumentNullException();
           
            var newNode = new Node<T>(value);

            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var current = Root;
                Node<T> parent;

                while (true)
                {
                    parent = current;
                    //Sol-alt ağaç
                    if (value.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
    }
}
