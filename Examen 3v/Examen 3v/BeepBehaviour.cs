using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3v
{
    internal class BeepBehaviour : Component
    {
        public int freq;
        private int dur;
        public BeepBehaviour(int freq, int dur)
        {
            this.freq = freq;
            this.dur = dur;
        }
        public override void Update()
        {
            char pressedKey = (char)Console.Read();
            if (pressedKey == 'F')
            {
                Console.Beep(freq, dur);
            }
        }
    }
}
