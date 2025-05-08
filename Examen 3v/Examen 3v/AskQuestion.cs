using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3v
{
    internal class AskQuestion : Component
    {
        private string question = "Cuantos vamos a suspender? (number)";
        public override void Update()
        {
            string awaitingAnswer = Console.ReadLine();
            Console.WriteLine(question);
            string input = Console.ReadLine();
            int answer = int.Parse(input);
            if (answer >= 10)
            {
                Console.WriteLine("CORRECT!");
                Console.Beep(600, 500);
            }
            else
            {
                 Console.WriteLine("Incorrect, more.");
            }
            if (input == "x")
            {
                Environment.Exit(0);
            }
            
        }
    }
}
