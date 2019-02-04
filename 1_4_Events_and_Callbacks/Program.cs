using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4_Events_and_Callbacks
{

    class Alarm
    {
        public Action OnAlarmRaised { get; set; }

        public void RaiseAlarm()
        {
            if (OnAlarmRaised != null)
            {
                OnAlarmRaised();
            }
        }

    }

    class Alarm2
    {
        public event EventHandler OnAlarmRaised2 = delegate { };



    }




    class Program
    {
        static void AlarmListener()
        {
            Console.WriteLine("Alarm listener called");


        }

        static void AlarmListener2()
        {
            Console.WriteLine("Alarm listener 2 called");
        }

        static void SlaskTratt()
        {
            Console.WriteLine("1234567890");
            Console.WriteLine("Press any key...");
            Console.ReadKey();


        }


        class Alarm1
        {
            public event EventHandler onAlarmRaised2 = delegate { };

            public void RaiseAlarm()
            {
                onAlarmRaised2(this, EventArgs.Empty);
            }
        }

        static void Main(string[] args)
        {
            // BettyBoopMain();

            //WrongMethod();

            Console.WriteLine(DateTime.Now.ToString());
            for (int i = 0; i < 95000000; i++)
            {
                if (i == 0)
                    Console.WriteLine(i.ToString("X"));
                else if ((i % 1000) == 0)
                    Console.WriteLine(i.ToString());
            }
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("End");
            Console.ReadKey();

        }

        private static void WrongMethod()
        {
            string outdata = "";

            for (int i = 0; i < 6; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    outdata = "";
                    switch (i)
                    {
                        case 0:
                            outdata = "A";
                            break;
                        case 1:
                            outdata = "B";
                            break;
                        case 2:
                            outdata = "C";
                            break;
                        case 3:
                            outdata = "D";
                            break;
                        case 4:
                            outdata = "E";
                            break;
                        case 5:
                            outdata = "F";
                            break;

                    }

                    outdata = outdata + j.ToString();
                    Console.WriteLine(outdata.ToString());
                }

            }
        }

        private static void BettyBoopMain()
        {
            Alarm alarm = new Alarm();

            alarm.OnAlarmRaised += AlarmListener;
            alarm.OnAlarmRaised += AlarmListener2;



            BettyBoop(alarm);

            alarm.RaiseAlarm();

            alarm.OnAlarmRaised -= AlarmListener;

            BettyBoop(alarm);

            
            alarm.RaiseAlarm();

            Console.WriteLine("Alarm raised");

            Console.ReadKey();
        }

        private static void BettyBoop(Alarm alarm)
        {
            alarm.OnAlarmRaised += SlaskTratt;
        }
    }
}
