using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2TMA.Lesson1
{
    class GSM
    {
        String _model, _manufacturer, _owner;
        float _price;

        Battery _battery;
        Display _display;
        Call _callHistory;


        public GSM(String model, String manufacturer, float price, String owner , Battery battery, Display display)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            Battery = battery;
            Display = display;

           
        }


        public GSM(String model, String manufacturer, float price, String owner, Battery battery, Display display,Call callHistory)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            Battery = battery;
            Display = display;
            CallHistory = callHistory;

        }



        public static GSM _gsm= new GSM("Iphone 4S", "Apple", 40000000, "Vu Khac Hoi", new Battery(BatteryType.Li_Ion, 4, 3), new Display(5, 255));

        public string Model { get => _model; set => _model = value; }
        public string Manufacturer { get => _manufacturer; set => _manufacturer = value; }
        public string Owner { get => _owner; set => _owner = value; }
        public float Price { get => _price; set => _price = value; }
        internal Battery Battery { get => _battery; set => _battery = value; }
        internal Display Display { get => _display; set => _display = value; }
        internal Call CallHistory { get => _callHistory; set => _callHistory = value; }

        public override string ToString()
        {
            return "GMS  :\n Model  : " + Model +
                            "  \n Manufacturer  : " + Manufacturer +
                            "  \n Price  : " + Price +
                            "  \n Owner  : " + Owner +
                            "  \n Battery  : Model : " + Battery.Model + " hour idle  : " + Battery.HoursIdle + " hour talk  :" + Battery.HoursTalk+
                            "  \n Display  : size : " + Display.Size + " Color : " + Display.Color ;
        }


    }
}
