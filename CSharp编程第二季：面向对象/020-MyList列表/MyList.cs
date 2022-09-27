using System;

namespace _020_MyList列表
{
    class MyList<T>
    {
        //泛型数组
        private T[] data = new T[0];
        //元素个数
        private int count = 0;

        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(T item)
        {
            if (data.Length == 0)
            {
                data = new T[4];
            }

            if (data.Length == count)
            {
                T[] temp = new T[count * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
                data = temp;
            }

            data[count] = item;
            count++;
        }

        public T this[int index]
        {
            set
            {
                if (index < 0 || index > count - 1)
                {
                    throw new System.Exception();
                }
                data[index] = value;
            }
            get
            {
                return data[index];
            }
        }

        public void Insert(int index, T item)   //把item插入到索引为index的位置
        {
            if (index < 0 || index > count - 1)
            {
                throw new System.Exception();
            }
            //遍历从最大索引到index
            for (int i = count - 1; i > index - 1; i--)
            {
                //数据后移
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > count - 1)
            {
                throw new System.Exception();
            }
            //遍历从index后面的数据到最大索引
            for (int i = index + 1; i < count; i++)
            {
                //数据前移
                data[i - 1] = data[i];
            }
            count--;
        }

        public int IndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(data[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public int LastIndexOf(T item)
        {
            int index = -1;
            for (int i = count - 1; i >= 0; i--)
            {
                if (item.Equals(data[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Sort()
        {
            //前count个数据排序
            Array.Sort(data, 0, count);
        }
    }
}
