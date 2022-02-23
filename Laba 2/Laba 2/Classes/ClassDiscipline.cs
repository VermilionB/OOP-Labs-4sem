using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Laba_2.Classes
{
    [Serializable]
    public class ClassDiscipline
    {
        public string DisciplineName { get; set; }
        public List<string> Semester { get; set; }
        public string Specilization { get; set; }
        public string Course { get; set; }
        public string Lections { get; set; }
        public int Labs { get; set; }
        public string Control { get; set; }

        public ClassDiscipline()
        {
            Semester = new List<string>();
        }
        public ClassDiscipline(string disciplineName, List<string> semester, string specialization,
            string course, string lections, int labs, string control)
        {
            DisciplineName = disciplineName;
            Semester = semester;
            Specilization = specialization;
            Course = course;
            Lections = lections;
            Labs = labs;
            Control = control;
        }

    }
}
