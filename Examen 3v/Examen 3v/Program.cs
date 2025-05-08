namespace Examen_3v
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor color1 = ConsoleColor.Cyan;
            ConsoleColor color2 = ConsoleColor.Red;
            char sprite1 = 'C';
            char sprite2 = 'F';
            int freq = 600;
            int dur = freq;

            Game_Object go1 = new Game_Object();
            Game_Object go2 = new Game_Object();

            SpriteRenderer sprRend1 = new SpriteRenderer(sprite1, color1);
            SpriteRenderer sprRend2 = new SpriteRenderer(sprite2, color2);
            go1.AddComponent(sprRend1);
            go2.AddComponent(sprRend2);


            BeepBehaviour beep = new BeepBehaviour(freq, dur);
            go1.AddComponent(beep);
            AskQuestion ask = new AskQuestion();
            go2.AddComponent(ask);

            List<Game_Object> gameObjs = new List<Game_Object>();
            gameObjs.Add(go1);
            gameObjs.Add(go2);

            // Start scene
            foreach (Game_Object go in gameObjs) 
            { 
                go.Start();
            }
            bool exit = false;
            while (!exit)
            {
                foreach (Game_Object go in gameObjs) 
                { 
                    go.Update(); 
                }
                Console.WriteLine("X to exit");
                char c = (char)Console.Read();
                if (c == 'X')
                {
                    exit = true;
                }
            }
            if (exit)
            {
                Environment.Exit(0);
            }
        }
    }
}
