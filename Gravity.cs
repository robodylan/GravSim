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
    class Gravity
    {
        public static int x = 0;
        public static int y = 0;

        public static void Move(object sender, MouseMoveEventArgs e)
        {
            Gravity.x = e.X;
            Gravity.y = e.Y;
        }
    }
}
