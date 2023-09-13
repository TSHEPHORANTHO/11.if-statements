using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsMale = true ;
            //if true/ opposite=(!gender)
            if (IsMale)
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("Female");
            }
            bool IsTall = true ;
            {
                if (IsTall && IsMale)
                {
                    Console.WriteLine("You Are a Male and Tall");
                }

                else if (!IsTall && IsMale)
                {
                    Console.WriteLine("You Are a Male and Short");
                }
                else if (!(IsMale && IsTall))
                {
                    Console.WriteLine("You Are not Female Neither Short");
                }
                else
                {
                    Console.WriteLine("You Are too old for this program");
                }
                Console.ReadLine();
            }
        }
    }
}
