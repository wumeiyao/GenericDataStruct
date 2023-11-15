using System;
namespace SimpleDataStruct.Struct.Line
{
    public class MyList<T>
    {
        const long originCapacity = 10;
        T[] array;
        public T this[long index]
        {
            get
            {
                if (index > curCount - 1 || index < 0)
                    throw new ArgumentOutOfRangeException();
                return array[index];
            }
            set
            {
                if (index > curCount - 1 || index < 0)
                    throw new ArgumentOutOfRangeException();
                array[index] = value;
            }
        }
        long curCount = 0;
        public long Count => curCount;
        public MyList()
        {
            array = new T[originCapacity];
        }
        public bool Contains(T item)
        {
            long index = -1;
            for (long i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                    index = i;
            }
            return index != -1;

        }
        public void AddItem(T item)
        {
            //检测容量
            if (curCount >= array.Length - 1)
            {
                Array.Resize(ref array, array.Length * 2);
            }
            array[curCount] = item;
            curCount++;
        }
        public bool RemoveItem(long index)
        {
            if (index > curCount - 1 || index < 0)
                return false;
            return RemoveItem(array[index]);
        }
        public bool RemoveItem(T item)
        {
            long index = -1;
            for (long i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                    index = i;
                if (index != -1)
                {
                    if (i + 1 <= array.Length - 1)
                        array[i] = array[i + 1];
                }
            }
            if (index != -1)
                curCount--;
            return index != -1;

        }
    }
}
