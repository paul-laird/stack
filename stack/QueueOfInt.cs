using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class QueueOfInt
    {
        private int[] data;
        private int tail = 0;
        private int head = 0;
        public QueueOfInt(int s)
        {
            data = new int[s];
        }
        public void enqueue(int i)
        {
            data[tail++] = i;
        }
        public int dequeue()
        {
            return data[head++];
        }

    }
}
