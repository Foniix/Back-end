using System.Collections.Generic;

namespace Task_3_and_6
{
    internal class MyDictionary<TKey, TValue>
    {
        private readonly List<TKey> _key;
        private readonly List<TValue> _value;

        public int Length { get; private set; }

        public MyDictionary()
        {
            _key = new List<TKey>();
            _value = new List<TValue>();
        }
        public TValue this[TKey i]
        {
            get => _key.Contains(i) ? _value[_key.IndexOf(i)] : default;
            set
            {
                if (_key.Contains(i))
                    _value[_key.IndexOf(i)] = value;
            }
        }
        public void Add(TKey k, TValue v)
        {
            if (_key.Contains(k)) return;
            _key.Add(k);
            _value.Add(v);
            Length++;
        }
        public void Remove(TKey k)
        {
            if (!_key.Contains(k)) return;
            _value.RemoveAt(_key.IndexOf(k));
            _key.Remove(k);
            Length--;
        }
        public void RemoveAt(int i)
        {
            if (i >= Length || i < 0) return;
            _key.RemoveAt(i);
            _value.RemoveAt(i);
            Length--;
        }
    }
}
