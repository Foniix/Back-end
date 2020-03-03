using System;
using System.Linq;

namespace Task7
{
    internal class ArrayList
    {
        public object[] MyArray;
        public int Size { get; private set; }

        public ArrayList()
        {
            MyArray = new object[] { };
            Size = 0;
        }

        public object this[int i]
        {
            get => MyArray[i];
            set => MyArray[i] = value;
        }
        public ArrayList(object[] obj)
        {
            MyArray = obj;
            Size = obj.Count();
        }

        public void Add(object obj)
        {
            Array.Resize(ref MyArray, ++Size);
            MyArray[Size - 1] = obj;
        }
        public void Clear()
        {
            MyArray = new object[] { };
            Size = 0;
        }

        public void Reverse()
        {
            var array = new object[Size];
            var temp = MyArray;
            var index = Size - 1;
            var i = 0;
            while (index >= 0)
            {
                array[index--] = temp[i++];
            }
            MyArray = array;

        }

        public object[] CopyTo(int from)
        {
            var temp = from;
            if (temp <= 0 || temp >= Size) return null;
            var newSize = Size - @from;
            var to = new object[newSize];
            for (var i = 0; i < newSize; i++)
            {
                to[i] = MyArray[temp];
                temp++;
            }
            return to;

        }
        public void AddRange(object[] range)
        {
            var temp = this.Size;
            var index = 0;
            var tempt = Size + range.Count();
            Array.Resize(ref MyArray, tempt);
            Size += range.Count();
            for (var i = temp; i < Size; i++)
            {
                MyArray[i] = range[index++];
            }
        }
        public void Remove(int rem)
        {
            var index = rem;
            for (var i = index; i < MyArray.Count() - 1; i++)
            {
                MyArray[i] = MyArray[i + 1];
            }
            Array.Resize(ref MyArray, --Size);
        }
    }
}
