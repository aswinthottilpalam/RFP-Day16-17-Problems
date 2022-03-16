using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPday16and17Problems
{
    class Anagram
    {
        public void Anagram_Check()
        {
            Console.WriteLine("Enter First Word: ");
            string w1 = Console.ReadLine();
            Console.WriteLine("Enter Second Word: ");
            string w2 = Console.ReadLine();

            char[] a = w1.ToLower().ToCharArray();
            char[] b = w2.ToLower().ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            string x = new string(a);
            string y = new string(b);

            if (x==y)
            {
                Console.WriteLine(w1 + " " + w2 + " " + "are Anagram");
            }
            else
            {
                Console.WriteLine(w1 + " " + w2 + " " + "are not Anagram");
            }
        }
    }
}
