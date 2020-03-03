using System;

namespace Task5
{
    internal class CarCollection<T, TU>
    {
        public Tuple<T, TU>[] Cars { get; set; }
        public int Size { get; private set; }


        public CarCollection()
        {
            Cars = new Tuple<T, TU>[] { };
            Size = 0;
        }

        public CarCollection(int size, params Tuple<T, TU>[] tuple)
        {
            Cars = tuple;
            Size = size;
        }

        public Tuple<T, TU> this[int i]
        {
            get => Cars[i];
            set => Cars[i] = value;
        }

        public void Add(T carName, TU year)
        {
            if (carName.GetType() != typeof(string) || year.GetType() != typeof(int)) return;
            var temp = new Tuple<T, TU>[++Size];
            for (var i = 0; i < Size - 1; i++)
            {
                temp[i] = Cars[i];
            }
            temp[Size - 1] = new Tuple<T, TU>(carName, year);
            Cars = temp;



        }

        public void DeleteAll()
        {
            var temp = new Tuple<T, TU>[0];
            Size = 0;
            Cars = temp;
        }

    }
}
