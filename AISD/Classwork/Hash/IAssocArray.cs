using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.Classwork.Hash
{
    public interface IAssocArray<TKey, TValue> : IEnumerable<TValue>
    {
        void Insert(TKey key, TValue value);
        bool Find(TKey key, TValue value);
        void Remove(TKey key, TValue value);
        void Clear();
    }
}
