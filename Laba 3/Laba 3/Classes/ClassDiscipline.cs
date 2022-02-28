using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Laba_3.Classes
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
        public ClassLector ClassLector { get; set; }

        public ClassLector TakeLector()
        {
            ClassLector lector = new ClassLector();
            using (StreamReader fs = new StreamReader(@"D:\УЧЕБА 4 СЕМ\ООП\OOP-Labs-4sem\Laba 3\Laba 3\jsonLector.json"))
            {
                return lector = JsonSerializer.Deserialize<ClassLector>(fs.ReadToEnd());
            }
        }
        

        public ClassDiscipline()
        {
            Semester = new List<string>();
            ClassLector = new ClassLector();
        }
        public ClassDiscipline(string disciplineName, List<string> semester, string specialization,
            string course, string lections, int labs, string control, ClassLector classLector)
        {
            DisciplineName = disciplineName;
            Semester = semester;
            Specilization = specialization;
            Course = course;
            Lections = lections;
            Labs = labs;
            Control = control;
            classLector = TakeLector();
            ClassLector = classLector;
        }

    }
}
