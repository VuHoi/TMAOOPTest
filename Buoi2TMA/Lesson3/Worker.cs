using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2TMA.Lesson3
{
    class Worker :Human
    {
        float weekSalary;
        float workHoursPerDay;


        public Worker(String lastName, String firstName, float weekSalary, float workHoursPerDay) : base(lastName, firstName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;

        }
        public float WeekSalary { get => weekSalary; set => weekSalary = value; }
        public float WorkHoursPerDay { get => workHoursPerDay; set => workHoursPerDay = value; }

        public float MoneyPerHour()
        {
            return WeekSalary / (7 * WorkHoursPerDay);
        }
    }
}
