using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            InternalRecursion(50);
            Pow(3, 2);
        }

        static int Pow(int num, int exponent)   // Noncompliant; no condition under which pow isn't re-called
        {
            num = num * Pow(num, exponent - 1);
            return num;  // this is never reached
        }

        static void InternalRecursion(int i)
        {
            start:
            goto end;
            end:
            goto start; // Noncompliant; there's no way to break out of this method
        }
    }


}
