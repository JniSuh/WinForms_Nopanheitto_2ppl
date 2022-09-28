using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace Nopanheitto_2ppl
{
    internal class Dice
    {
        public int Value = 0;

        public static int Roll(PictureBox dice)
        {
            Random random = new Random();
            int val = random.Next(1, 7);

            ///<summary>
            ///     Yritin saada satunnaisemman numeron kuin Random.Next:illä.
            ///     Tuntuu tosin tulevan enemmän 5 ja 6 lukuja.
            /// </summary>

            //int val = 0;
            //while (val < 1 || val > 6)
            //{
            //    val = int.Parse((Math.PI / random.Next(1, 10)).ToString().Substring(random.Next(2, 16), 1));
            //}

            dice.Image = GetImage("_" + val);

            return val;
        }

        public static void diceAnimation(PictureBox dice, int incr_X, int incr_Y) { dice.Location = new Point(dice.Location.X + incr_X, dice.Location.Y + incr_Y); }

        public static Image GetImage(string name)
        {
            return (Image)DiceFaces.DiceFaces.ResourceManager.GetObject(name);
        }
    }
}
