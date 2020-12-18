using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubler
{
    class NumWork
    {
        Stack<int> history = new Stack<int>();
        public string Add1(string text)
        {
            int num = int.Parse(text);
            history.Push(num);
            num = num < int.MaxValue - 1 ? num + 1 : num;
            return num.ToString();
        }
        public string Mult2(string text)
        {
            int num = int.Parse(text);
            history.Push(num);
            num = num < int.MaxValue / 2 ? num * 2 : num;
            return num.ToString();
        }
        public string Undo()
        {
            if (history.Count != 0)
            {
                return history.Pop().ToString();
            }
            return "1";
        }
        public string Next()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2000).ToString();
        }
    }
}
