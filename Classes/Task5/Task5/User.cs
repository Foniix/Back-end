using System;

namespace Task5
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }



        public override string ToString()
        {
            DateTime date = DateTime.Today;
            return $"Логин: {Login}\nИмя: {FirstName}\nФамилия: {LastName}\nВозраст: {Age}\nДата создания анкеты - {date}";
        }
    }
}
