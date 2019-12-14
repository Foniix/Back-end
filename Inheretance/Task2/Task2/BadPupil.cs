using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class BadPupil : Pupil 
    {
        public override void Descr()
        {
            Console.WriteLine("Bad pupil!");
        }
        public override void Study()
        {
            Console.WriteLine("Study: 0 из 10");
        }

        public override void Read()
        {
            Console.WriteLine("Read: 2 из 10");
        }

        public override void Write()
        {
            Console.WriteLine("Write: 2 из 10");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax: 10 из 10");
        }
    }
}
