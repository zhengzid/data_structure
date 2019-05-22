using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    public abstract class Node<T> : IDisposable
    {
        public virtual T Data { get; set; }



        public virtual void Dispose()
        {
            Console.WriteLine("this node has been delete,data is {0} ", Data);
        }
    }
}
