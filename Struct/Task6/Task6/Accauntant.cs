namespace Task6
{
    class Accauntant
    {
        public bool AskForBonus(Position worker, int hours)
        {
            return (int)worker < hours;
        }
    }
}
