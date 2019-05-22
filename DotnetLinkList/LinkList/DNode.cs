using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class DNode<T> : Node<T>
    { 
        public DNode<T> Next { get; set; }
        public DNode<T> Pre { get; set; }


        public DNode()
        {
            Data = default(T);
            Next = null;
            Pre = null;
        }
        public DNode(T data , DNode<T> pre, DNode<T> next)
        {
            Pre = pre;
            Next = next;
            Data = data;
        }

        public DNode(T data)
        { 
            Data = data;
        }

    }
}
