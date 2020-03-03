namespace Task2
{
    internal class MyList<T>
    {
        public T[] MyArray;
        public int Size { get; private set; }

        public MyList()
        {
            Size = 0;
            MyArray = new T[] { };

        }
        public MyList(int size, params T[] list)
        {
            Size = size;
            MyArray = list;
        }
        public T this[int i]
        {
            get => MyArray[i];
            set
            {
                if (i <= Size)
                    MyArray[i] = value;
            }
        }

        public void Add(T newElement)
        {
            Size++;
            var newMyArray = new T[Size];
            for (var i = 0; i < Size - 1; i++)
            {
                newMyArray[i] = MyArray[i];
            }
            newMyArray[Size - 1] = newElement;
            MyArray = newMyArray;
        }
    }
}
