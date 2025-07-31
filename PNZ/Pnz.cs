using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNZ
{
    internal class Pnz
    {
        int num;
        public Pnz()
        {
            num = 2;
        }
        public Pnz(int num)
        {
            this.num = num;
        }
        public void check()
        {
            if (num == 0)
            {
                Console.WriteLine("number is zero");
            }
            else if (num > 1)
            {
                Console.WriteLine("number is positive");

            }
            else
            {
                Console.WriteLine("its negative");
            }
        }
    }
}