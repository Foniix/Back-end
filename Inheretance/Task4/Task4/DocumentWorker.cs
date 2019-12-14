﻿using System;

namespace Task4
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Pro");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Pro");
        }
    }
}
