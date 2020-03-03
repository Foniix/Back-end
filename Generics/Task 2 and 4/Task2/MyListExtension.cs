namespace Task2
{
    internal static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.MyArray;
        }
    }
}
