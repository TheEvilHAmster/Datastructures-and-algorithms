using System;
using Datastructures_and_algorithms;

namespace Datastructures_and_algorithms
{
    
    public interface IDynamicList<T>
    {
        public int Count { get; }

        public int IndexOf(T item);

        public bool Contains(T item);

        public void Add(T item);

        public void Insert(int index, T item);

        public void RemoveAt(int index);

        public bool Remove(T item);

        public void Clear();

        public void CopyTo(T[] target, int index);

        public T this[int index]
        {
            get;
            set;
        }
    }
    
    
    public class DList<T> : IDynamicList<T>
    {
        private const int INITIAL_CAPACITY = 4;
        private const int MAXIMUM_GROWTH = 64;

        private T[] _items;
        private int _count;
        private int _capacity;

        /* Interface */

        public int Count {
            get {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (object.Equals(item, _items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public void Add(T item)
        {
            manageSize();
            _items[_count++] = item;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > _count)
            {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }
            manageSize();
            Array.Copy(_items, index, _items, index + 1, _count - index);
            _items[index] = item;
            _count++;
        }

        // Alternative: return the removed item
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Invalid index: " + index);
            }
            Array.Copy(_items, index + 1, _items, index, _count - index - 1);
            _count--;
            _items[_count] = default(T);
        }

        // Alternative: return index 
        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public void Clear()
        {
            _items = new T[INITIAL_CAPACITY];
        }

        public void CopyTo(T[] target, int index)
        {
            int maxTargetItems = target.Length - index;
            Array.Copy(_items, 0, target, index, Math.Min(_items.Length, maxTargetItems));
        }

        /* Indexer */

        public T this[int index]
        {
            get {
                return _items[index];
            }
            set {
                if (index < 0 || index >= _count) // Should be able to Add to list?
                {
                    throw new IndexOutOfRangeException("Invalid index: " + index);
                }
                _items[index] = value;
            }
        }

        /* Constructor */

        public DList(int capacity = INITIAL_CAPACITY)
        {
            this._items = new T[capacity];
            this._count = 0;
        }

        /* Internal methods */

        private void manageSize()
        {
            if (_count == _items.Length)
            {
                _capacity = _items.Length < MAXIMUM_GROWTH ? _items.Length * 2 : _items.Length + MAXIMUM_GROWTH;
                T[] expanded = new T[_capacity];
                _items.CopyTo(expanded, 0);
                _items = expanded;
            }
        }
    }
    
    public class DynamicListsThings
    {
        
        // DList<String> words = new DList<String>(4);
        // words.Add("Hello");
        // words.Add("World");
        // words.Add("this");
        // words.Add("fine");
        // words.Add("day");
        // words.Insert(3, "very");
        // words.RemoveAt(4);
        // words.Remove("World");
        // words[0] = "Bye bye";
        //
        // String[] otherWords = new string[5];
        // words.CopyTo(otherWords, 2);
        //
        // for (int i=0; i<words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }
        //
        // Console.WriteLine("\nCount: " + words.Count);
        // Console.WriteLine("Capacity: " + words.Capacity);
        //
        // foreach (var word in otherWords)
        // {
        //     Console.WriteLine(word);
        // }

        private DList<String> word = new DList<string>();
        

    }
}