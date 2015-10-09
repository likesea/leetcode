using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    /// <summary>
    /// 食物链 POJ1182
    /// </summary>
    public class FoodChain
    {
        private int[] _types;
        private int[] _x;
        private int[] _y;
        public FoodChain(int [] types, int[] x,int []y)
        {
            _types = types;
            _x = x;
            _y = y;
        }

        public int Solve()
        {
            int ans = 0;
            int length = _types.Length;
            MergeFindSet2 mergeSet = new MergeFindSet2(3*length);
            for (int i = 0; i < length; i++)
            {
                int x = _x[i] - 1, y = _y[i] - 1;
                int t = _types[i];
                
                //不正确的编号
                if (x < 0 || length <= x || y < 0 || y >= length)
                {
                    ans++;
                    continue;
                }

                //同一种
                if (t == 1)
                {
                    if (mergeSet.Same(x, y + length) || mergeSet.Same(x, y + 2*length))
                    {
                        ans++;
                    }
                    else
                    {
                        mergeSet.Unite(x,y);
                        mergeSet.Unite(x+length, y+length);
                        mergeSet.Unite(x+2*length, y+2*length);
                    }
                }
                if (t == 2)
                {
                    if (mergeSet.Same(x, y) || mergeSet.Same(x, y + 2*length))
                    {
                        ans++;
                    }
                    else
                    {
                        mergeSet.Unite(x,y+length);
                        mergeSet.Unite(x+length,y+2*length);
                        mergeSet.Unite(x+2*length,y);
                    }
                }
                return ans;
            }
        }
    }
}
