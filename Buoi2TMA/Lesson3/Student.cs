using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2TMA.Lesson3
{
    class Student :Human
    {
        float grade;

        public Student(String lastName,  String firstName,float grade) :base (lastName,firstName)
        {
            Grade = grade;
                
        }

        public float Grade { get => grade; set => grade = value; }
    }
}
