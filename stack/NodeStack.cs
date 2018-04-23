using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class NodeStack
    {
        IntNode head;

        public void push(int i)
        {
            head=new IntNode(i,head);
        }
        public int pop()
        {
            int val = head.Val;
            head=head.Next;
            return val;
        }
    }
}
