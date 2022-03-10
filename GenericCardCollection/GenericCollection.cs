using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCardCollection
{
  
    public class GenericCollection<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> collection = new Dictionary<TKey, TValue>();

        public bool AddElement(TKey k, TValue v)
        {
            if (collection.ContainsKey(k))
            {
                return false;
            }
            collection.Add(k, v);
            return true;
        }

        public TValue GetElement(TKey k)
        {
            if (collection.ContainsKey(k))
                return collection[k];
            else
                throw new ArgumentException("key findes ikke");
        }

      
        public int Size()
        {
            return collection.Count();
        }
    }
}
