using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public byte Age;

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
    }
}
