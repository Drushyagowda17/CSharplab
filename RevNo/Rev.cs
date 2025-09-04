using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RevNo
{
    public class Rev
    {
        int num;
        int temp;
        int rev = 0;
        public Rev(int num) 
        {
            this.num = num;
        }
        public void process()
        {
            while (num > 0)
            {
                temp = num % 10;
                num /= 10;
                rev = rev * 10 + temp;
            }
        }
            public void display()
        {
            Console.WriteLine($"The reversed number is {rev}");
        }
    }
}


