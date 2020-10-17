using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Game
{
    class DrawerBorderV2Class
    {
        public void drawGame(char one, char two, char three, char four, char five, char six, char seven, char eath_8, char nine, char A, bool newLine)
        {
            char[] Chars = new char[30];
            Chars[0] = one;
            Chars[1] = two;
            Chars[2] = three;
            Chars[3] = four;
            Chars[4] = five;
            Chars[5] = six;
            Chars[6] = seven;
            Chars[7] = eath_8;
            Chars[8] = nine;
            Chars[9] = A;

            for (int i = 0; i < 10; i++)
            {
               Console.Write(Chars[i]); 
            }


        }
        public void drawGame(char sym)
        {
            char[] Chars = new char[30];
            

            for (int i = 0; i < Chars.Length; i++)
            {
                Chars[i] = sym;
            }


            for (int i = 0; i < Chars.Length; i++)
            {
                Console.Write(Chars[i]);
            }


        }
        public void drawGame( char[] body)
        {
            char[] Chars = new char[30];
            Chars[0] = body[0];
            Chars[29] = body[0];

            for (int i = 1; i < body.Length; i++)
            {
                Chars[i] = body[i];
            }
            

            for (int i = 0; i < 30; i++)
            {
                Console.Write(Chars[i]);
            }


        }


    }
}
