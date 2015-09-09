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
        private Dictionary<T, T> dic =new Dictionary<T, T>();
        private Dictionary<T, int> rank = new Dictionary<T,int>();  

        public void Add(T item)
        {
            dic.Add(item,default(T));
            rank.Add(item,0);
        }

        public T FindParent(T item)
        {
            if (dic[item].Equals(item))
            {
                return item;
            }
            else
            {
                return dic[item] = FindParent(item);
            }
        }

        public void Unite(T x, T y)
        {
            x = FindParent(x);
            y = FindParent(y);
            if (x.Equals(y)) return;
            if (rank[x] > rank[y])
            {
                dic[y] = x;
            }
            else
            {
                dic[x] = y;
                if (rank[x] == rank[y]) rank[y]++;
            }
        }

        public bool SameParent(T x, T y)
        {
            return FindParent(x).Equals(FindParent(y));
        }
    }
}
