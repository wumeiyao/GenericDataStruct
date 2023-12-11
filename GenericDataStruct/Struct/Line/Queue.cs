using System;
using System.Text;

namespace GenericDataStruct.Struct.Line
{
    public class Queue<T>
    {
        T[] array;

        public Queue(int capacity)
        {
            array = new T[capacity];
        }
        public T DeQueue()
        {
            //System.Collections.Generic.Queue
            return default(T);
        }
        public void EnQueue(T t)
        {

        }
    }
}
