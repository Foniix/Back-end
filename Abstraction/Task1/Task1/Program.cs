using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file type:\n1.XML\n2.DOC\n3.TXT");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var xmlhandler = new XMLHandler();
                    xmlhandler.Open();
                    xmlhandler.Create();
                    xmlhandler.Change();
                    xmlhandler.Save();
                    break;
                case 2:
                    var dochandler = new DOCHandler();
                    dochandler.Open();
                    dochandler.Create();
                    dochandler.Change();
                    dochandler.Save();
                    break;
                case 3:
                    var txthandler = new TXTHandler();
                    txthandler.Open();
                    txthandler.Create();
                    txthandler.Change();
                    txthandler.Save();
                    break;
                default:
                    break;
            }
        }
    }
}
