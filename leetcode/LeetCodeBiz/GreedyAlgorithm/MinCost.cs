using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    /// <summary>
    /// fence repair
    /// </summary>
    public class MinCost
    {
        private int _length;
        private int[] _fences;
        private int cost;
        public MinCost(int length, int[] fences)
        {
            _fences = fences;
            _length = length;
        }

        public int Solve()
        {
            int N = _fences.Length;
            cost = 0;
            while (N>1)
            {
                int min1 = 0;
                int min2 = 1;
                if(_fences[min1]>_fences[min2]) swap(min1,min2);
                for (int i = 2; i < N; i++)
                {
                    if (_fences[i] < _fences[min1])
                    {
                        min2 = min1;
                        min1 = i;
                    }
                    else if(_fences[i]<_fences[min2] )
                    {
                        min2 = i;
                    }
                }
                int t = _fences[min1] + _fences[min2];
                cost += t;
                //if(min1==N-1) swap(min1,min2);
                _fences[min1] = t;
                _fences[min2] = _fences[N - 1];
                N--;
            }
            return cost;
        }

        private void swap(int min1, int min2)
        {
            var temp = _fences[min1];
            _fences[min1] = _fences[min2];
            _fences[min2] = temp;
        }
    }
}
