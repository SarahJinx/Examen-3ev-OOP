using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3v
{
    internal class SpriteRenderer : Component
    {
        private SpriteRenderer sprite;
        private object color;

        public SpriteRenderer(char sprRend, ConsoleColor color)
        {
            this.sprite = sprite;
            this.color = color;
        }

        public override void Start()
        {
            Console.WriteLine(sprite);
        }

        public override void Update()
        {
            Console.BackgroundColor = (ConsoleColor)color;
            Console.Write(sprite);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
