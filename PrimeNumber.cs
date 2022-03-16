using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPday16and17Problems
{
    class PrimeNumber
    {
        public void PrimeNumberCheck()
        {
            for (int i = 0; i <= 1000; i++)
            {
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
