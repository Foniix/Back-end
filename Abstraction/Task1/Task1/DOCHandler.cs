using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change DOC File!");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC File!");
        }

        public override void Open()
        {
            Console.WriteLine("Open DOC File!");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC File!");
        }
    }
}
