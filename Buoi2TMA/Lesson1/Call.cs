using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2TMA.Lesson1
{
    class Call
    {

        String date, time, phoneNumber, duration;


        public Call(String date,String time,String phoneNumber,String duration)
        {
            this.date = date;
            this.time = time;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }


        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Duration { get => duration; set => duration = value; }
    }
}
