using System.Drawing;

namespace Generic_custom_list
{
    public class CustomList<T>
    {
        public int count { get; set; } = 0;
        public int capacity { get; set; } = 4;
        public T[] list = { };
        //private int _index = 0;
        public CustomList() 
        {
            list = new T[capacity];
        }
        public CustomList(int capacity) 
        { 
            if(capacity < 1) capacity = 4;
            this.capacity = capacity;
            list = new T[capacity];
        }
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity = capacity * 2;
                Array.Resize(ref list, capacity);
            }
            list[count] = item;
            count++;
        }

        public T? Find(Predicate<T> match)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (match(list[i]))
                {
                    return list[i];
                }
            }
            return default;
        }
        public CustomList<T> FindAll(Predicate<T> match)
        {
            CustomList<T> newList = new CustomList<T>() { };
            foreach (T item in list)
            {
                if(match(item))
                    newList.Add(item);
            }
            return newList;
        }
        public bool Contains(T value)
        {
            for (int i = 0; i < capacity; i++)
            {
                if(i <= count - 1)
                {
                    T Value = list[i];
                    if (Value.Equals(value))
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public bool Exists(Predicate<T> match)
        {
            foreach (T item in list)
            { 
                if(match(item))
                    return true;
            }
            return false;
        }

        public bool Remove(T value)
        {
            int index = 0;
            bool found = false;
            for(int i = 0; i < count; i++)
            {
                if (list[i].Equals(value)) 
                { 
                    index = i;
                    found = true;
                }
            }
            for (int i = index; i < count - 1; i++)
            {
                list[i] = list[i + 1];
            }
            list[count - 1] = default(T);
            count--;
            return found;
        }
    }
}
