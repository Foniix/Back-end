using System;

namespace Task3
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Class Change";
        }
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "Struct Change";
        }
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            var myStruct = new MyStruct();
            myClass.change = "Class doesn't Change";
            myStruct.change = "Struct doesn't Change";
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.WriteLine($"Struct: {myStruct.change}\nClass: {myClass.change}");
            Console.ReadKey();
        }
    }
}
