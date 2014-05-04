using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Start
    {
        static void Main(string[] args)
        {
            Game.Start();
        }

        public static double Deg2Rad(int Deg){
            double Rad;
            Rad = Deg * Math.PI / 180;
            return Rad;
        }
    }
}
