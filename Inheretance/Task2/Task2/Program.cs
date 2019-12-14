using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil firstPupil = new ExcelentPupil();
            Pupil secondPupil = new GoodPupil();
            Pupil thirdPupil = new ExcelentPupil();
            Pupil fourthPupil = new BadPupil();

            ClassRoom classRoom = new ClassRoom(firstPupil, secondPupil, thirdPupil, fourthPupil);

            foreach (Pupil p in classRoom.Pupils)
            {
                p.Descr();
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
