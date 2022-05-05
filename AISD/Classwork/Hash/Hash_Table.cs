using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Classwork.Hash
{
    /// <summary>
    /// Хеш-таблица на основе связных списков - мне не нравится
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class HashTable<TValue> : IAssocArray<int, TValue>
    {
        private List<TValue>[] array;

        public HashTable(int maxKeyValue)
        {
            array = new List<TValue>[maxKeyValue];
        }

        public void Insert(int key, TValue value)
        {
            if (array[key] == null)
                array[key] = new List<TValue>();
            array[key].Add(value);
        }

        public bool Find(int key, TValue value)
        {
            return array[key].Contains(value);
        }

        public void Remove(int key, TValue value)
        {
            array[key].Remove(value);
        }
        public void Clear()
        {
            foreach (var list in array)
                list.Clear();
        }

        public IEnumerator<TValue> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
