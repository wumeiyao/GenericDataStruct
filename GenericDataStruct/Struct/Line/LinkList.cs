using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDataStruct.Struct.Line
{

    public class SingleLinkList<T>
    {
        private Node<T> head;
        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public SingleLinkList()
        {
            head = null;
        }
        public T this[int index]
        {
            get
            {
                return this.GetItemAt(index);
            }
        }
        public int Count()
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                len++;
                p = p.Next;
            }
            return len;
        }
        public void Clear()
        {
            head = null;
        }
        public void Append(T item)
        {
            Node<T> d = new Node<T>(item);
            Node<T> n = new Node<T>();

            if (head == null)
            {
                head = d;
                return;
            }

            n = head;
            while (n.Next != null)
            {
                n = n.Next;
            }
            n.Next = d;
        }
        public void InsertBefore(T item, int i)
        {
            if (head == null || i < 0)
            {
                return;
            }
            if (i == 0)
            {
                Node<T> q = new Node<T>(item);
                q.Next = Head;
                head = q;
                return;
            }
            Node<T> n = head;
            Node<T> d = new Node<T>();
            int j = 0;
            while (n.Next != null && j < i)
            {
                d = n;
                n = n.Next;
                j++;
            }
            if (n.Next == null)
            {
                Node<T> q = new Node<T>(item);
                n.Next = q;
                q.Next = null;
            }
            else
            {
                if (j == i)
                {
                    Node<T> q = new Node<T>(item);
                    d.Next = q;
                    q.Next = n;
                }
            }
        }
        public void InsertAfter(T item, int i)
        {
            if (head == null || i < 0)
            {
                return;
            }
            if (i == 0)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head.Next = q;
                return;
            }
            Node<T> p = head;
            int j = 0;
            while (p != null && j < i)
            {
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }
        }
        public T RemoveAt(int i)
        {
            if (head == null || i < 0)
            {
                return default(T);
            }

            Node<T> q = new Node<T>();
            if (i == 0)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }

            Node<T> p = head;
            int j = 0;

            while (p.Next != null && j < i)
            {
                j++;
                q = p;
                p = p.Next;
            }

            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                return default(T);
            }
        }
        public T GetItemAt(int i)
        {
            if (head == null)
            {
                return default(T);
            }

            Node<T> p = new Node<T>();
            p = head;

            if (i == 0)
            {
                return p.Data;
            }

            int j = 0;

            while (p.Next != null && j < i)
            {
                j++;
                p = p.Next;
            }

            if (j == i)
            {
                return p.Data;
            }
            else
            {
                return default(T);
            }
        }
        public int IndexOf(T value)
        {
            if (head == null)
            {
                return -1;
            }
            Node<T> p = new Node<T>();
            p = head;
            int i = 0;
            while (!p.Data.Equals(value) && p.Next != null)
            {
                p = p.Next;
                i++;
            }
            return i;
        }
        public void Reverse()
        {
            SingleLinkList<T> result = new SingleLinkList<T>();
            Node<T> t = this.head;
            result.Head = new Node<T>(t.Data);
            t = t.Next;
            while (t != null)
            {
                result.InsertBefore(t.Data, 0);
                t = t.Next;
            }
            this.head = result.head;
            result = null;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> n = this.head;
            sb.Append(n.Data.ToString() + ",");
            while (n.Next != null)
            {
                sb.Append(n.Next.Data.ToString() + ",");
                n = n.Next;
            }
            return sb.ToString().TrimEnd(',');

        }
    }
}

