using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change XML File!");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML File!");
        }

        public override void Open()
        {
            Console.WriteLine("Open XML File!");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML File!");
        }
    }
}
