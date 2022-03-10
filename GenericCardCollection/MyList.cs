using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCardCollection
{
    internal class MyList<TData>
    {
        Element<TData> first = null;
        Element<TData> current = null;

        public void AddElement(TData data)
        {
            if (first == null)
            {
                var element = new Element<TData>(data);
                first = element;
                current = element;
            }
            else
            {
                var element = new Element<TData>(data);
                current.Next = element;
                current = current.Next;  
            }
        }

        public TData GetElement(int index)
        {
            if (first == null)
                throw new IndexOutOfRangeException();   
            else
            {
                var cur = first;
                for (int i = 0; i < index; i++)
                {
                    if (cur.Next == null)
                        throw new IndexOutOfRangeException();
                    cur = cur.Next;
                }
                return cur.Data;
            }
        }
    }
}
