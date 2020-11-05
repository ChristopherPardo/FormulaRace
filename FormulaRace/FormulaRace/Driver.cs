using System;

namespace FormulaRace
{
    public class Driver
    {
        private string name;
        private string lastname;
        private int number;

        public Driver(string name, string lastname, int number)
        {
            this.name = name;
            this.lastname = lastname;
            this.number = number;
        }

        public string Name
        {
            get { return this.lastname; }
        }

        public string Lastname
        {
            get { return this.lastname; }
        }

        public int Number
        {
            get { return this.number; }
        }
    }
}
