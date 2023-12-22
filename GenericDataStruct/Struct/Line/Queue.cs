/*
 *
 */
using System;
using System.Text;

namespace GenericDataStruct.Struct.Line
{
    //
    public class Queue<T>
    {
        private LinkList<T> m_link;
        public Queue()
        {
            m_link = new LinkList<T>();
        }
        public int Count()
        {
            return m_link.Count();
        }
        public T DeQueue()
        {
            if (m_link.Count() == 0)
                return default;
            return m_link.RemoveAt(0);
        }
        public void EnQueue(T t)
        {
            m_link.Append(t);
        }
        public void Clear()
        {
            m_link.Clear();
        }
    }
}
