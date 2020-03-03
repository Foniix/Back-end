namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var integerValue = MyClass<int>.FactoryMethod();
            var doubleValue = MyClass<double>.FactoryMethod();
            var stringValue = MyClass<string>.FactoryMethod();
        }
    }
}
