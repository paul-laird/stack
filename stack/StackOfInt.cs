using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class StackOfInt
    {
        private int[] data;
        private int top = 0;
        public StackOfInt(int s)
        {
            data = new int[s];
        }
        public void push(int i)
        {
            data[top++] = i;
        }
        public int pop()
        {
            return data[--top];
        }
    }
}
