using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsList
{
    class GenericsList<T>
    {
        public int Length { get; private set; }
        private GenericsNode<T> firstNode;

        public GenericsList()
        {
            Length = 0;
            firstNode = null;
        }

        //insert into head of the list
        public void Insert(T data)
        {
            GenericsNode<T> newNode = new(data);
            newNode.Next = firstNode;
            firstNode = newNode;
            Length++;
        }

        //get first element
        public T GetFirst()
        {
            if (Length == 0)
                throw new ArgumentException("the list is empty");
            return firstNode.Data;
        }

        public static void Foreach(GenericsList<T> list, Action<T> action)
        {
            GenericsNode<T> pointer = list.firstNode;
            while (pointer != null)
            {
                action(pointer.Data);
                pointer = pointer.Next;
            }
        }
    }
}
