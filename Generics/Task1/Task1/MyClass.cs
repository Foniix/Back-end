namespace Task1
{
    internal class MyClass<T>
    {
        public static MyClass<T> FactoryMethod()
        {
            return new MyClass<T>();
        }
    }
}
