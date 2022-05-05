using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Homework._2_Semester_Hw._28._04._2022Events
{
    public class ElectricalStation 
    {
        private int temp = 0;
        public int Temp 
        {
            get {return  temp; }
        }
        private int crTemp;
        public int CrTemp 
        {
            get { return crTemp; }
            set 
            {                
                if (value < 0)
                    Console.WriteLine("Критическая температура не может быть меньше нуля!");
                else
                    crTemp = value;
            }
        }
        private bool Stop = true;

        public ElectricalStation(int _crtemp)
        {
            CrTemp = _crtemp;
        }

        public EventHandler<ElectricalStation> CallDelegate;

        public void StartSt(Object o)
        {
            
            if (temp >= crTemp && CallDelegate != null && Stop== true )
            {
                CallDelegate(null, this);
                Stop = false;
            }
            
            temp += 3;
            

        }

        public void Timer()
        {
            TimerCallback tmCall = new TimerCallback(StartSt);

            Timer tm = new Timer(tmCall, null, 0, 200);
        }







    }
}
