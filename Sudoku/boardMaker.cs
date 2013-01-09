using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    class boardmaker
    {
        public Random Randomizer;

        int[] row1 = { 1, 2};
        int[] row2 = { 3, 4};
        int[] row3 = { 5, 6};
        int[] row4 = { 7, 8};
        int[] row5 = { 9};
        

        public int G1()
        {
            int randomrow1 = row1[Randomizer.Next(row1.Length)];

            return randomrow1;
        }
        public int G2()
        {
            int randomrow2 = row2[Randomizer.Next(row2.Length)];

            return randomrow2;
        }
        public int G3()
        {
            int randomrow3 = row3[Randomizer.Next(row3.Length)];

            return randomrow3;
        }
        public int G4()
        {
            int randomrow4 = row4[Randomizer.Next(row4.Length)];

            return randomrow4;
        }
        public int G5()
        {
            int randomrow5 = row5[Randomizer.Next(row5.Length)];

            return randomrow5;
        }
       
    }
}

