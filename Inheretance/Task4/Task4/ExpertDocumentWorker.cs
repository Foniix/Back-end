﻿using System;

namespace Task4
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public new string Key { get; } = "Expert";

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
