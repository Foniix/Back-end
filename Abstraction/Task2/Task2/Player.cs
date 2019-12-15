using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Player : IPayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play music");
        }

        public void Record()
        {
            Console.WriteLine("Recording..."); ;
        }
        void IPayable.Pause()
        {
            Console.WriteLine("Pause music");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Recording pause");
        }

        void IPayable.Stop()
        {
            Console.WriteLine("Playing stoped");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Recording stoped");
        }
    }
}
