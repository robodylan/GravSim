

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Import SFML
using SFML.Audio;
using SFML.Graphics;
using SFML.Window;

namespace Constructor
{
    public class Particle
    {
        public float x;
        public float y;
        public float Speed;
        public float rot;
        public int Lifetime = 10;
        public int LastSpawn = 100;
        public Color c;
        public byte R;
        public byte G;
        public byte B;
        public Particle(int id,int x,int y)
        {
            /*Code For Generating Particles */

            Random r = new Random(id * 6);
            //Generate Random Color
            this.R = (byte)new Random(id /9).Next(0, 255);
            this.G = (byte)new Random(id / 7).Next(0, 255);
            this.B = (byte)new Random(id /8).Next(0, 255);
            c = new Color(R,G,B);
            //Generate Random Speed
            Speed = new Random(id).Next(1, 100) / new Random(id * 7).Next(5,10);
            this.x = x;
            this.y = y;
            rot = new Random((int)id / 18 * (int)Speed).Next(1, 360);
        }
        public void Update()
        { 
             /*--------------------------------------*\
             /*  Add Code For Updating Particles Here *\
             /*---------------------------------------*\
 
            //Example:
            rot++;
            x = (float)(x + Speed* Math.Sin(Start.Deg2Rad((int)this.rot)));
            y = (float)(y + Speed*Math.Cos(Start.Deg2Rad((int)this.rot)));
            if(this.x > Gravity.x){
                x = x - Speed / 5f;
            }
            if (this.x < Gravity.x)
            {
                x = x + Speed / 5f;
            }
            if (this.y > Gravity.y)
            {
                y = y - Speed / 5f;
            }
            if (this.y < Gravity.y)
            {
                y = y + Speed / 5f;
            }
             */

        }
    }
}

