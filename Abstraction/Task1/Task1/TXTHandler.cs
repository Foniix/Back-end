using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change TXT File!");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT File!");
        }

        public override void Open()
        {
            Console.WriteLine("Open TXT File!");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT File!");
        }
    }
}
