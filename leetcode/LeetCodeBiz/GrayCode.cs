using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    public class GrayCodeSolution
    {
        public IList<int> GrayCode(int n)
        {
            var list =GetGrayList(n);
            List<int> listInt = new List<int>();
            foreach (var item in list)
            {
                listInt.Add(Convert.ToInt32(item,2));
            }
            return listInt;
        }

        private IList<string> GetGrayList(int n)
        {
            if (n == 0) return new List<string>(){"0"};
            if (n==1) return new List<string>(){"0","1"};
            List<string> list = GetGrayList(n - 1).ToList();
            var listCopy = new List<string>();
            int length = list.Count;
            for (int i = 0; i < length; i++)
            {
                listCopy.Add("1" + list[i]);
                list[i] = "0" + list[i];
                
            }
            listCopy.Reverse();
            list.AddRange(listCopy);
            return list;
        } 
    }
}
