using System;

namespace Task2
{
    struct Train
    {
        public string DestinationPoint { get; set; }
        public int TrainNum { get; set; }
        public string DepartureTime { get; set; }
        public Train(string destPoint, int num, string time)
        {
            DestinationPoint = destPoint;
            TrainNum = num;
            DepartureTime = time;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Train[8];
            for (var i = 0; i < 8; i++)
            {
                try
                {
                    Console.WriteLine("Введите номер поезда:"); 
                    trains[i].TrainNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите название пункта назначения:"); 
                    trains[i].DestinationPoint = Console.ReadLine();
                    Console.WriteLine("Введите время прибытия(вводите в формате ЧЧ:ММ:СС):"); 
                    trains[i].DepartureTime = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно введенные данные"); break;
                }
            }

            Array.Sort(trains, (a, b) => a.TrainNum.CompareTo(b.TrainNum));
            while (true)
            {
                var checker = false;
                Console.WriteLine("Введите номер поезда, информацию о котором вы хотите узнать. Для выхода введите '-1'");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input == -1) break;
                foreach (var tr in trains)
                {
                    if (input != tr.TrainNum) continue;
                    Console.WriteLine($"Номер поезда - {tr.TrainNum}, пункт назначения - {tr.DestinationPoint}, время прибытия - {tr.DepartureTime}"); 
                    checker = true;

                }
                if (!checker) Console.WriteLine("Поезда с таким номером нет.");
            }
        }
    }
}
