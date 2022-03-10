using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCardCollection
{
    internal class Element<TData>
    {
        public TData Data { get; set; }
        public Element<TData> Next { get; set; }

        public Element(TData data)
        {
            Data = data;
            Next = null;
        }

    }
}
