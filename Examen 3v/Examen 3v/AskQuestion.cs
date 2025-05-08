using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3v
{
    internal class AskQuestion : Component
    {
        private string question1 = "Cuantos somos en clase?";
        private string question2 = "Cuantos vamos a suspender?";
        public override void Update()
        {
            Console.WriteLine(question1);
            Console.ReadLine();
            Console.WriteLine(question2);
            Console.ReadLine();
            if (question1 == question2)
            {
                Console.Beep(600, 500);
            }
        }
    }
}
