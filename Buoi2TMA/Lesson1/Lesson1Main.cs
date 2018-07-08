using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2TMA.Lesson1
{
    class Lesson1Main
    {
        public static void run()
        {
            GSM gSM = new GSM("Redmi note 4", "Xiaomi", 40000000, "Vu Khac Hoi", new Battery(BatteryType.Li_Ion, 4, 3), new Display(5, 255));
            Console.WriteLine("display GSM \n");
            Console.WriteLine(gSM.ToString());
            Console.WriteLine("display GSM static \n");
            Console.WriteLine(GSM._gsm.ToString());
            Console.WriteLine("Input GSM Array \n");

            GSM [] _gsm = new GSM[10];

            inputData(ref _gsm);
            outputData(_gsm);


            List<GSM> gSMs = new List<GSM>();
            inputData(ref gSMs);
            removeDataWithIndex(ref gSMs,0);
            removeDataWithChild(ref gSMs, gSMs[1]);
            outputData(gSMs);
            CalculatePrice(gSMs);
        }


      private static  void inputData(ref GSM [] gsm )
        {
            String Name, Manufacturer,owner;
            float price;
            int _hoursIdle;
            int _hoursTalk;
            int _size, _color;
            BatteryType NameB;
            for (int i = 0; i < gsm.Length; i++)
            {
                Console.WriteLine("index "+i +"\n" );
                Console.Write("Name Phone  : ");Name = Console.ReadLine();
                Console.Write("Manufacturer Phone  : "); Manufacturer = Console.ReadLine();
                Console.Write("Price Phone  : "); price = float.Parse(Console.ReadLine());
                Console.Write("owner Phone  : "); owner = Console.ReadLine();
                Console.Write("Name Battery  : "); NameB = BatteryType.Li_Ion;
                Console.Write("Hour talk Battery  : "); _hoursTalk = int.Parse( Console.ReadLine());
                Console.Write("Hour idle Battery  : "); _hoursIdle = int.Parse(Console.ReadLine());
                Console.Write("Color Display  : "); _color = int.Parse(Console.ReadLine());
                Console.Write("Size Display  : "); _size = int.Parse(Console.ReadLine());

                gsm[i] = new GSM(Name, Manufacturer, price, owner, new Battery(NameB, _hoursIdle, _hoursTalk), new Display(_size, _color));
            }



        }



        private static void inputData(ref List<GSM> gsm)
        {
            String Name, Manufacturer, owner;
            float price;
            int _hoursIdle;
            int _hoursTalk;
            int _size, _color;
            BatteryType NameB;
            for (int i = 0; i < gsm.Count; i++)
            {
                Console.WriteLine("index " + i + "\n");
                Console.Write("Name Phone  : "); Name = Console.ReadLine();
                Console.Write("Manufacturer Phone  : "); Manufacturer = Console.ReadLine();
                Console.Write("Price Phone  : "); price = float.Parse(Console.ReadLine());
                Console.Write("owner Phone  : "); owner = Console.ReadLine();
                Console.Write("Name Battery  : "); NameB = BatteryType.Li_Ion;
                Console.Write("Hour talk Battery  : "); _hoursTalk = int.Parse(Console.ReadLine());
                Console.Write("Hour idle Battery  : "); _hoursIdle = int.Parse(Console.ReadLine());
                Console.Write("Color Display  : "); _color = int.Parse(Console.ReadLine());
                Console.Write("Size Display  : "); _size = int.Parse(Console.ReadLine());

                gsm.Add(new GSM(Name, Manufacturer, price, owner, new Battery(NameB, _hoursIdle, _hoursTalk), new Display(_size, _color)));
            }



        }

        private static void outputData( GSM[] gsm)
        {
            
            for (int i = 0; i < gsm.Length; i++)
            {
                Console.WriteLine(gsm[i].ToString());
            }
        }



        private static void removeDataWithIndex(ref List<GSM> gsm,int index)
        {

            gsm.RemoveAt(index);
        }
        private static void removeDataWithChild(ref List<GSM> gsm, GSM child)
        {

            gsm.Remove(child);
        }
        private static void outputData(List<GSM> gsm)
        {

            for (int i = 0; i < gsm.Count; i++)
            {
                Console.WriteLine(gsm[i].ToString());
            }
        }

        private static float  CalculatePrice(List<GSM> gsm)
        {

            float totalPrice=0;
            for (int i = 0; i < gsm.Count; i++)
            {
                totalPrice += gsm[i].Price;
            }

            return totalPrice;
        }


     
    }
}
