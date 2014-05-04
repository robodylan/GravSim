

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Import SFML
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;

namespace Constructor
{
    class Game
    {
        //Define Assets
        public static int T = 0;
        public static Random r = new Random();
        public static List<Particle> cs = new List<Particle>();
        public static Sprite enemy = new Sprite(new Texture("Content/Enemy.png"), new IntRect(0, 0, 8, 8));
        public static Sprite player = new Sprite(new Texture("Content/Player.png"), new IntRect(0, 0, 64, 64));
        public static RenderWindow window = new RenderWindow(new VideoMode(1600, 1000), "I Am Goc");
        public static void Start(){
            enemy.Texture.Smooth = true;
            enemy.Texture.Smooth = false;
            window.SetFramerateLimit(120);
            window.MouseMoved += Gravity.Move;
            window.Closed += Close;
            while (window.IsOpen())
            {
                window.Clear(new Color(0, 0, 0));
                for (int i = 1; i < 5; i++)
                {
                    Game.cs.Add(new Particle(T * i, (int)window.Size.X / 2, (int)window.Size.Y / 2));
                }
                T++;
                //window.Clear(new Color(0,0,0));
                window.DispatchEvents();
                Update();
                window.Display();
            }
        }


        //Update Enemy Position
        public static void Update()
        {
            //Draw Sprite For Every Instance Of Enemy Constructor
            for (int l = cs.Count - 2; l >= 0; l--)
            {
                if(cs.Count > 5000){
                    cs.Remove(cs[l]);
                }
                enemy.Color = cs[l].c;
                cs[l].Update();
                enemy.Position = new Vector2f(cs[l].x, cs[l].y);
                window.Draw(enemy);
                if(cs[l].x > window.Size.X || cs[l].x < 0){
                    cs.Remove(cs[l]);
                }
                if (cs[l].y > window.Size.Y || cs[l].y < 0)
                {
                    cs.Remove(cs[l]);
                }
            }
        }
        public static void Close(Object sender, EventArgs e)
        {
            window.Close();
        }


    }
}

