using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsList
{
    class GenericsNode<T>
    {
        public T Data { get; set; }
        public GenericsNode<T> Next { get; set; }

        public GenericsNode(T d)
        {
            Data = d;
            Next = null;
        }
    }
}
