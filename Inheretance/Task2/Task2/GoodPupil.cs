using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class GoodPupil : Pupil
    {
        public override void Descr()
        {
            Console.WriteLine("Good pupil!");
        }
        public override void Study()
        {
            Console.WriteLine("Study: 5 из 10");
        }

        public override void Read()
        {
            Console.WriteLine("Read: 5 из 10");
        }

        public override void Write()
        {
            Console.WriteLine("Write: 5 из 10");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax: 8 из 10");
        }
    }
}
