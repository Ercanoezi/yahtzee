using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class Conclusie
    {
        public void Worp(ref int[] a, ref int b, ref int c)
        {
            int i = 0;

            foreach (int z in a)
                if (a[i] == c)
                {
                    b += 1;
                    i++;
                }
                else
                {
                    i++;
                }
        }

        public void Uitkomst(int a, int b, int c, int d, int e, int f, ref string score)
        {
            if (a == 5 || b == 5 || c == 5 || d == 5 || e == 5 || f == 5)
            {
                score = "Yahtzee!!";
            }
            else if ((a == 3 || b == 3 || c == 3 || d == 3 || e == 3 || f == 3) && (a == 2 || b == 2 || c == 2 || d == 2 || e == 2 || f == 2))
            {
                score = "Full House!!";
            }
            else if ((a == 1 && b == 1 && c == 1 && d == 1 && e == 1) || (b == 1 && c == 1 && d == 1 && e == 1 && f == 1))
            {
                score = "Grote straat!!";
            }
            else if ((a >= 1 && b >= 1 && c >= 1 && d >= 1) || (b >= 1 && c >= 1 && d >= 1 && e >= 1) || (c >= 1 && d >= 1 && e >= 1 && f >= 1))
            {
                score = "Kleine straat!";
            }
            else if (a == 4 || b == 4 || c == 4 || d == 4 || e == 4 || f == 4)
            {
                score = "4 of a kind";
            }
            else if (a == 3 || b == 3 || c == 3 || d == 3 || e == 3 || f == 3)
            {
                score = "3 of a kind";
            }
            else
            {
                score = "LOOOOSSSEEEERRRRRR!!";
            }
        }
    }
}
