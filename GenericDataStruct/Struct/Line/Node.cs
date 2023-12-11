using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataStruct.Struct.Line
{
    public class Node<T>
    {
        private Node<T> last;
        private T data;
        private Node<T> next;
        public Node() { }
        public Node(T val)
        {
            data = val;
        }
        public Node(T val, Node<T> last, Node<T> next)
        {
            data = val;
            this.last = last;
            this.next = next;
        }
        public Node(T val, Node<T> next)
        {
            data = val;
            this.next = next;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Last
        {
            get { return last; }
            set { last = value; }
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }
    }
}

