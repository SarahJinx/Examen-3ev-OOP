using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_3v
{
    internal class Game_Object 
    {
        private List<Component> components;
        public Game_Object()
        {
            components = new List<Component>();
        }
        public void AddComponent(Component comp)
        {
            components.Add(comp);
        }
        public void Start()
        {
            foreach (Component comp in components) { comp.Start(); }
        }
        public void Update()
        {
            foreach (Component comp in components) { comp.Update(); }
        }
    }
}
