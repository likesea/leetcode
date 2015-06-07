using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBiz
{
    public class CountAndSayProblem
    {
        public  string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            else
                return Say(CountAndSay(n - 1));
        }

        private  string Say(string s)
        {
            int count = 0;
            string result = string.Empty;
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == s[j] && i != s.Length - 1)
                {
                    count++;
                }
                else if (s[i] == s[j] && i == s.Length - 1)
                {
                    count++;
                    result += count.ToString() + s[j];
                }
                else if (s[i] != s[j] && i == s.Length - 1)
                {
                    result += count.ToString() + s[j];
                    result += "1" + s[i].ToString();
                }
                else if (s[i] != s[j] && i != s.Length - 1)
                {
                    result += count.ToString() + s[j];
                    count = 1;
                    j = i;
                }
            }
            return result;
        }
    }
}
