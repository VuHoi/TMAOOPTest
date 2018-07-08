using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2TMA.Lesson1
{
    class Battery
    {
        BatteryType _model;

        int _hoursIdle;
        int _hoursTalk;

        public Battery(BatteryType model, int hoursIdle, int hoursTalks)
        {
            Model = model;
            HoursIdle = hoursIdle;
            HoursTalk = hoursTalks;
        }

        public int HoursIdle { get => _hoursIdle; set => _hoursIdle = value; }
        public int HoursTalk { get => _hoursTalk; set => _hoursTalk = value; }

        internal BatteryType Model { get => _model; set => _model = value; }
    }
}
