using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    /// <summary>
    /// 并查集
    /// </summary>
    public class MergeFindSet<T> where T : IEquatable<int>
    {
        private readonly Dictionary<T, T> _dic =new Dictionary<T, T>();
        private readonly Dictionary<T, int> _rank = new Dictionary<T,int>();  

        public void Add(T item)
        {
            _dic.Add(item,default(T));
            _rank.Add(item,0);
        }

        public T FindParent(T item)
        {
            if (_dic[item].Equals(item))
            {
                return item;
            }
            return _dic[item] = FindParent(item);
        }

        public void Unite(T x, T y)
        {
            x = FindParent(x);
            y = FindParent(y);
            if (x.Equals(y)) return;
            if (_rank[x] > _rank[y])
            {
                _dic[y] = x;
            }
            else
            {
                _dic[x] = y;
                if (_rank[x] == _rank[y]) _rank[y]++;
            }
        }

        public bool SameParent(T x, T y)
        {
            return FindParent(x).Equals(FindParent(y));
        }
    }
}
