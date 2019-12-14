using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class ExcelentPupil : Pupil
    {
        public override void Descr()
        {
            Console.WriteLine("Excelent pupil!");
        }
        public override void Study()
        {
            Console.WriteLine("Study: 10 из 10");
        }

        public override void Read()
        {
            Console.WriteLine("Read: 10 из 10");
        }

        public override void Write()
        {
            Console.WriteLine("Write: 10 из 10");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax: 0 из 10");
        }
    }
}
