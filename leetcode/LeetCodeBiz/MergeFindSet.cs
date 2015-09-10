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

    public class MergeFindSet2
    {
        private int[] parent;
        private int[] rank;

        public MergeFindSet2(int n)
        {
            parent = new int[n];
            rank = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }
        }

        public int Find(int x)
        {
            if (parent[x] == x)
            {
                return x;
            }
            return parent[x] = Find(parent[x]);
        }

        public void Unite(int x, int y)
        {
            x = Find(x);
            y = Find(y);
            if (x == y) return;
            if (rank[x] < rank[y])
            {
                parent[x] = y;
            }
            else
            {
                parent[y] = x;
                if (rank[x] == rank[y]) rank[x]++;
            }
        }

        public bool Same(int x, int y)
        {
            return Find(x) == Find(y);
        }
    }
}
