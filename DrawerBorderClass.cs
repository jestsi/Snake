using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class DrawerBorderClass
    {
        public void drawBorder ()
        {

            short i = 0;


            while (true)
            {
                //draw border top
                if (i <= 75)
                {
                    Console.Write("_");
                    if (i == 75)
                        Console.Write("\n");

                    i++;
                }
                //draw border left and right
                if (i > 75 && i <= 103)
                {
                    Console.WriteLine("#\t\t\t\t\t\t\t\t\t   #");
                    i++;
                }

                //draw border bottom
                if (i <= 178 && i > 102)
                {
                    Console.Write("=");
                    i++;
                }
            }
        }
    }
}
