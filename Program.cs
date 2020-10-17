using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using Timer = System.Timers.Timer;


namespace Snake_Game
{
    class Program
    {
        #region FormsSetChar
        public static char[] setCharsOne()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwo()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsThree()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsFour()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsOnFive()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsSix()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsSeven()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsEight()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsNine()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTen()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsEleven()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwelve()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsThirtTeen()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsOneFourTeen()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsFifteen()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsSixTeen()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsSevenTeen()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsEightTeen()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsNineTeen()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwenty()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsOneTwentyOne()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwentyTwo()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwentyThree()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwentyFour()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwentyFive()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwentySix()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwentySeven()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwentyEight()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsTwentyNine()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }

        public static char[] setCharsThirty()
        {
            char sym = '#';
            char snakeSym = 'A';
            char[] st = new char[30];

            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';

            return st;
        }
        #endregion

        public static int numSymGo = 15;
        public static int realLine = 15;
        static Timer timer = new Timer();
        #region lines
        static List<char[]> line = new List<char[]> {
                    setCharsOne(),
                    setCharsTwo(),
                    setCharsThree(),
                    setCharsFour(),
                    setCharsOnFive(),
                    setCharsSix(),
                    setCharsSeven(),
                    setCharsEight(),
                    setCharsNine(),
                    setCharsTen(),
                    setCharsEleven(),
                    setCharsTwelve(),
                    setCharsThirtTeen(),
                    setCharsOneFourTeen(),
                    setCharsFifteen(),
                    setCharsSixTeen(),
                    setCharsSevenTeen(),
                    setCharsEightTeen(),
                    setCharsNineTeen(),
                    setCharsTwenty(),
                    setCharsOneTwentyOne(),
                    setCharsTwentyTwo(),
                    setCharsTwentyThree(),
                    setCharsTwentyFour(),
                    setCharsTwentyFive(),
                    setCharsTwentySix(),
                    setCharsTwentySeven(),
                    setCharsTwentyEight(),
                    setCharsTwentyNine(),
                    setCharsThirty()
                };

        /* char[] line1 = setCharsOne();
        char[] line2 = setCharsTwo();
        char[] line3 = setCharsThree();
        char[] line4 = setCharsFour();
        char[] line5 = setCharsOnFive();
        char[] line6 = setCharsSix();
        char[] line7 = setCharsSeven();
        char[] line8 = setCharsEight();
        char[] line9 = setCharsNine();
        char[] line10 = setCharsTen();
        char[] line11 = setCharsEleven();
        char[] line12 = setCharsTwelve();
        char[] line13 = setCharsThirtTeen();
        char[] line14 = setCharsOneFourTeen();
        char[] line15 = setCharsFifteen();
        char[] line16 = setCharsSixTeen();
        char[] line17 = setCharsSevenTeen();
        char[] line18 = setCharsEightTeen();
        char[] line19 = setCharsNineTeen();
        char[] line20 = setCharsTwenty();
        char[] line21 = setCharsOneTwentyOne();
        char[] line22 = setCharsTwentyTwo();
        char[] line23 = setCharsTwentyThree();
        char[] line24 = setCharsTwentyFour();
        char[] line25 = setCharsTwentyFive();
        char[] line26 = setCharsTwentySix();
        char[] line27 = setCharsTwentySeven();
        char[] line28 = setCharsTwentyEight();
        char[] line29 = setCharsTwentyNine();*/


        #endregion

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetWindowSize(34, 32);


            timer.Interval = 400;
            timer.Elapsed += Timer_Elapsed;
            while (true)
            {

                timer.Start();
                ConsoleKeyInfo key;

                key = Console.ReadKey();

                try
                {
                    while (key.Key == ConsoleKey.LeftArrow)
                    {
                        line[realLine][numSymGo] = '<';
                        line[realLine][numSymGo + 1] = ' ';
                        numSymGo -= 1;


                        Thread.Sleep(500);
                    }

                    while (key.Key == ConsoleKey.RightArrow)
                    {
                        line[realLine][numSymGo] = '>';
                        line[realLine][numSymGo - 1] = ' ';
                        numSymGo += 1;
                        Thread.Sleep(500);
                    }

                    while (key.Key == ConsoleKey.UpArrow)
                    {
                        line[realLine][numSymGo] = '^';
                        line[realLine + 1][numSymGo] = ' ';
                        realLine -= 1;
                        Thread.Sleep(500);
                    }

                    while (key.Key == ConsoleKey.DownArrow)
                    {
                        line[realLine][numSymGo] = '▽';
                        line[realLine - 1][numSymGo] = ' ';
                        realLine += 1;
                        Thread.Sleep(500);
                    }

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Вы проиграли((");
                    timer.Stop();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Вы проиграли((");
                    timer.Stop();
                }

            }
        }

        public static char[] setCharsGlob()
        {
            char sym = '#';
            char[] st = new char[30];
            st[0] = sym;
            st[1] = ' '; st[10] = ' '; st[19] = ' '; st[28] = ' ';
            st[2] = ' '; st[11] = ' '; st[20] = ' '; st[29] = sym;
            st[3] = ' '; st[12] = ' '; st[21] = ' ';
            st[4] = ' '; st[13] = ' '; st[22] = ' ';
            st[5] = ' '; st[14] = ' '; st[23] = ' ';
            st[6] = ' '; st[15] = ' '; st[24] = ' ';
            st[7] = ' '; st[16] = ' '; st[25] = ' ';
            st[8] = ' '; st[17] = ' '; st[26] = ' ';
            st[9] = ' '; st[18] = ' '; st[27] = ' ';
            return st;
        }


        public static void update(char[] area, char[] reloadLine)
        {


            DrawerBorderV2Class drawerBorderV2Class = new DrawerBorderV2Class();
            char sym = '#'; // символ крайов


            drawerBorderV2Class.drawGame(sym); // прорисовка верхней полосы

            for (int i = 0; i < 27; i++)
            {
                Console.Write("\n");
                drawerBorderV2Class.drawGame(area);
            }
            Console.Write("\n");
            drawerBorderV2Class.drawGame(reloadLine);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(sym); // прорисовка нижней полосы
            Console.Write("\n");

        }

        public static void update(
        #region arens
            char[] area0,
            char[] area1,
            char[] area2,
            char[] area3,
            char[] area4,
            char[] area5,
            char[] area6,
            char[] area7,
            char[] area8,
            char[] area9,
            char[] area10,
            char[] area11,
            char[] area12,
            char[] area13,
            char[] area14,
            char[] area15,
            char[] area16,
            char[] area17,
            char[] area18,
            char[] area19,
            char[] area20,
            char[] area21,
            char[] area22,
            char[] area23,
            char[] area24,
            char[] area25,
            char[] area26,
            char[] area27,
            char[] area28

        #endregion
            )
        {

            Console.Clear();
            DrawerBorderV2Class drawerBorderV2Class = new DrawerBorderV2Class();
            char sym = '#'; // символ крайов


            drawerBorderV2Class.drawGame(sym); // прорисовка верхней полосы 1 stroka

            #region draws
            Console.Write("\n");
            drawerBorderV2Class.drawGame(area0);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area1);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area2);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area3);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area4);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area5);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area6);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area7);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area8);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area9);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area10);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area11);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area12);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area13);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area14);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area15);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area16);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area17);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area18);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area19);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area20);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area21);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area22);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area23);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area24);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area25);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area26);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area27);

            Console.Write("\n");
            drawerBorderV2Class.drawGame(area28);

            #endregion


            Console.Write("\n");
            drawerBorderV2Class.drawGame(sym); // прорисовка нижней полосы 30 stroka
            Console.Write("\n");

        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                /*
                #region lines
                List<char[]> line = new List<char[]> {
                    setCharsOne(),
                    setCharsTwo(),
                    setCharsThree(),
                    setCharsFour(),
                    setCharsOnFive(),
                    setCharsSix(),
                    setCharsSeven(),
                    setCharsEight(),
                    setCharsNine(),
                    setCharsTen(),
                    setCharsEleven(),
                    setCharsTwelve(),
                    setCharsThirtTeen(),
                    setCharsOneFourTeen(),
                    setCharsFifteen(),
                    setCharsSixTeen(),
                    setCharsSevenTeen(),
                    setCharsEightTeen(),
                    setCharsNineTeen(),
                    setCharsTwenty(),
                    setCharsOneTwentyOne(),
                    setCharsTwentyTwo(),
                    setCharsTwentyThree(),
                    setCharsTwentyFour(),
                    setCharsTwentyFive(),
                    setCharsTwentySix(),
                    setCharsTwentySeven(),
                    setCharsTwentyEight(),
                    setCharsTwentyNine(),
                    setCharsThirty()
                };

                /* char[] line1 = setCharsOne();
                char[] line2 = setCharsTwo();
                char[] line3 = setCharsThree();
                char[] line4 = setCharsFour();
                char[] line5 = setCharsOnFive();
                char[] line6 = setCharsSix();
                char[] line7 = setCharsSeven();
                char[] line8 = setCharsEight();
                char[] line9 = setCharsNine();
                char[] line10 = setCharsTen();
                char[] line11 = setCharsEleven();
                char[] line12 = setCharsTwelve();
                char[] line13 = setCharsThirtTeen();
                char[] line14 = setCharsOneFourTeen();
                char[] line15 = setCharsFifteen();
                char[] line16 = setCharsSixTeen();
                char[] line17 = setCharsSevenTeen();
                char[] line18 = setCharsEightTeen();
                char[] line19 = setCharsNineTeen();
                char[] line20 = setCharsTwenty();
                char[] line21 = setCharsOneTwentyOne();
                char[] line22 = setCharsTwentyTwo();
                char[] line23 = setCharsTwentyThree();
                char[] line24 = setCharsTwentyFour();
                char[] line25 = setCharsTwentyFive();
                char[] line26 = setCharsTwentySix();
                char[] line27 = setCharsTwentySeven();
                char[] line28 = setCharsTwentyEight();
                char[] line29 = setCharsTwentyNine();


                #endregion
                try
                {
                    line[realLine][numSymGo] = '^';
                    realLine -= 1;
                    numSymGo += 1;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Вы проиграли((");
                    timer.Stop();  
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Вы проиграли((");
                    timer.Stop();
                }
                */

                //if (numSymGo > 3)
                //    numSymGo -= 1;
                //go[numSymGo + 1] = ' ';
                //go[numSymGo] = '<';


                //if (numSymGo < 25)
                //  numSymGo += 1;
                //go[numSymGo + 1] = ' ';
                //go[numSymGo] = '>';
                // еще нужно изменить numSymGo (если в лево то 25 если в право то 3)

                //  update(
                #region parametrs
                /*
                    line1,
                    line2,
                    line3,
                    line4,
                    line5,
                    line6,
                    line7,
                    line8,
                    line9,
                    line10,
                    line11,
                    line12,
                    line13,
                    line14,
                    line15,
                    line16,
                    line17,
                    line18,
                    line19,
                    line20,
                    line21,
                    line22,
                    line23,
                    line24,
                    line25,
                    line26,
                    line27,
                    line28,
                    line29
           */
                #endregion
                //        );

                update(
                #region parametrs
                    line[1],
                    line[2],
                    line[3],
                    line[4],
                    line[5],
                    line[6],
                    line[7],
                    line[8],
                    line[9],
                    line[10],
                    line[11],
                    line[12],
                    line[13],
                    line[14],
                    line[15],
                    line[16],
                    line[17],
                    line[18],
                    line[19],
                    line[20],
                    line[21],
                    line[22],
                    line[23],
                    line[24],
                    line[25],
                    line[26],
                    line[27],
                    line[28],
                    line[29]

                #endregion
                    );

            }
            catch (NotImplementedException)
            {
                throw;
            }
            //throw new NotImplementedException("gg");
        }
    }
}
