using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public class SNode<T> : Node<T>
    { 
        public SNode<T> Next { get; set; }


        public SNode()
        {
            Data = default(T);
            Next = null;
        }
        public SNode(T data,SNode<T> next)
        {
            Next = next;
            Data = data;
        }

        public SNode(T data)
        { 
            Data = data;
        }

    }
}
