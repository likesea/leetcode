using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz.Queue
{
    public class PriorityQueue<T>
    {
        private readonly SortedSet<T> _set = new SortedSet<T>(); 

        public void Add(T item)
        {
            _set.Add(item);
        }

        public T Top()
        {
            return _set.Max;
        }

        public void Remove(T item)
        {
            _set.Remove(item);
        }

        public bool IsEmpty()
        {
            return _set.Count == 0;
        }
    }
}
