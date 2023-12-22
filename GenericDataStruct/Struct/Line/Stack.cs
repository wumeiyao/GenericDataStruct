/*
 *
 */
using System;
using System.Text;

namespace GenericDataStruct.Struct.Line
{
    //
    public class Stact<T>
    {
        private LinkList<T> m_link;
        public Stact()
        {
            m_link = new LinkList<T>();
        }
        public int Count()
        {
            return m_link.Count();
        }
        public T Popup()
        {
            if (m_link.Count() == 0)
                return default;
            return m_link.RemoveAt(m_link.Count() - 1);
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
