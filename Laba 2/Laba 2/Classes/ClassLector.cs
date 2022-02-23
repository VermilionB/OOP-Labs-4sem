using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_2.Classes
{
    [Serializable]
    public class ClassLector
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime Date { get; set; }

        public ClassLector(string name, string department, DateTime date)
        {
            Name = name;
            Department = department;
            Date = date;
        }

        public ClassLector() { }
    }
}
