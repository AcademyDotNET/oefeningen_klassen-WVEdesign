using System;
using System.Collections.Generic;
using System.Text;

namespace Studentklasse // Handboek1 pagina 71
{
    class Student
    {
        public string student;

        public string GetStudent()
        {
            return student;
        }

        public void SetStudent(string value)
        {
            student = value;
        }

        public Student()
        {

        }
        public void GeefOverzicht()
        {
            Console.WriteLine(value: $"student {GetStudent()}");
        }
    }
}
