using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2TMA.Lesson3
{
    class Lesson3Main
    {

        public static void run()
        {
            List<Human> students = new List<Human>();
            List<Human> workers = new List<Human>();
            List<Human> humans = new List<Human>();
            inputStudent(ref students);
            students.Sort((a, b) => (a as Student).Grade.CompareTo((b as Student).Grade));
            inputWorker(ref workers);
            workers.Sort((a, b) => (b as Worker).WorkHoursPerDay.CompareTo((a as Worker).WorkHoursPerDay));
            students.AddRange(workers);
            humans = students;
            humans.Sort((a, b) => (a as Worker).FirstName.CompareTo((b as Worker).FirstName) != 0 ?
                                        (a as Worker).FirstName.CompareTo((b as Worker).FirstName) : 
                                        (a as Worker).LastName.CompareTo((b as Worker).LastName));

        }



        private static void inputStudent( ref List<Human> humans )
        {
            String firstName;
            String lastName;
            float grade;
            for (int i = 0; i < 1; i++)
            {
                Console.Write("input your first name : ");
                firstName = Console.ReadLine();
                Console.Write("input your lastname name : ");
                lastName = Console.ReadLine();
                Console.Write("input your grade name : ");
                grade = float.Parse(Console.ReadLine());
                humans.Add(new Student(lastName, firstName, grade));
            }
        }


        private static void inputWorker(ref List<Human> humans)
        {
            String firstName;
            String lastName;
            float weekSalary;
            float workHoursPerDay;
            for (int i = 0; i < 1; i++)
            {
                Console.Write("input your first name : ");
                firstName = Console.ReadLine();
                Console.Write("input your lastname name : ");
                lastName = Console.ReadLine();
                Console.Write("input your week Salary : ");
                weekSalary = float.Parse(Console.ReadLine());
                Console.Write("input your week work Hours Per Day : ");
                workHoursPerDay = float.Parse(Console.ReadLine());
                humans.Add(new Worker(lastName, firstName, weekSalary, workHoursPerDay));
            }
        }
    }
}
