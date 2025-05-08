using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3v
{
    internal class SpriteRenderer : Component
    {
        private char sprite;
        private ConsoleColor color;
        public SpriteRenderer(char sprite, ConsoleColor color)
        {
            this.sprite = sprite;
            this.color = color;
        }
        public override void Update()
        {
            Console.ForegroundColor = color;
            Console.Write(sprite);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
