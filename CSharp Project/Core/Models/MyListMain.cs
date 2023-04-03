using System;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Core.Models;

public class MyList<T> : IEnumerable<T>
{
    private T[] data;
    private int count = 0;
    private int capacity;
    public int Count { get { return count; } }
    public T this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            data[index] = value;
        }
    }

    public MyList(int initialCapacity = 4)
    {
        if (initialCapacity < 1) throw new ArgumentOutOfRangeException();
        this.capacity = initialCapacity;
        data = new T[initialCapacity];
    }

    private void Resize()
    {
        T[] resized = new T[capacity * 2];
        for (int i = 0; i < capacity; i++)
        {
            resized[i] = data[i];
        }
        data = resized;
        capacity = capacity * 2;
    }

    public void Add(T newElement)
    {
        if (newElement == null)
            throw new ArgumentNullException();
        if (count == capacity)
        {
            Resize();
        }

        data[count] = newElement;
        count++;
    }

    public bool Contains(T value)
    {
        if (value == null)
            throw new ArgumentNullException();
        for (int i = 0; i < count; i++)
        {
            if (value.Equals(data[i]))
            {
                return true;
            }
        }
        return false;
    }

    public bool Exists(Predicate<T> predicate)
    {
        if (predicate == null)
            throw new ArgumentNullException();
        for (int i = 0; i < count; i++)
        {
            if (predicate(data[i]))
            {
                return true;
            }
        }
        return false;
    }

    public T Find(Predicate<T> predicate)
    {
        if (predicate == null)
            throw new ArgumentNullException();
        for (int i = 0; i < count; i++)
        {
            if (predicate(data[i]))
            {
                return data[i];
            }
        }
        return default(T);
    }

    public List<T> FindAll(Predicate<T> predicate)
    {
        if (predicate == null)
            throw new ArgumentNullException();
        List<T> result = new List<T>();
        for (int i = 0; i < count; i++)
        {
            if (predicate(data[i]))
            {
                result.Add(data[i]);
            }
        }
        return result;
    }

    public int FindIndex(Predicate<T> predicate)
    {
        if (predicate == null)
            throw new ArgumentNullException();
        for (int i = 0; i < count; i++)
        {
            if (predicate(data[i]))
            {
                return i;
            }
        }
        return -1;
    }

    public int IndexOf(T value)
    {
        if (value == null)
            throw new ArgumentNullException();
        for (int i = 0; i < count; i++)
        {
            if (data[i].Equals(value))
            {
                return i;
            }
        }
        return -1;
    }

    public void Reverse()
    {
        int startIndex = 0;
        int endIndex = count - 1;
        while (startIndex < endIndex)
        {
            T temp = data[startIndex];
            data[startIndex] = data[endIndex];
            data[endIndex] = temp;
            startIndex++;
            endIndex++;
        }
    }

    public bool Remove(T value)
    {
        if (value == null)
            throw new ArgumentNullException();
        int index = IndexOf(value);
        for (int i = index; i < count - 1; i++)
        {
            data[i] = data[i + 1];
        }
        count--;
        return true;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach(T item in data)
        {
            if (item == null)
                break;
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}
