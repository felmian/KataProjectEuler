using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataProjectEuler.Problems
{
    class _009_SpecialPythagoreanTriplet : IProblemResult
    {
        const int ISKOMOE = 1000;
        public void GetResult()
        {
            //long counter = 1;

            for (int a = 0; a < ISKOMOE; a++)                 //a
            {
                for (int b = a + 1; b < ISKOMOE; b++)         //b
                {
                    for (int c = b + 1; c < ISKOMOE; c++)     //c
                    {
                        if (IsTriplet(a, b, c))
                        {

                            if (IsIskomoe(a, b, c))
                            {
                                //Console.WriteLine($"[{counter++}] a={a}; b={b}; c={c};");
                                //Console.WriteLine($"[{counter++}] a={a * a}; b={b * b}; c={c * c};");
                                Console.WriteLine("9:   " + a * b * c);
                                return;
                            }
                        }
                    }
                }
            }
        }
        private static bool IsIskomoe(int a, int b, int c)
        {
            return (a + b + c) == ISKOMOE && a * a + b * b == c * c;
        }

        private static bool IsTriplet(int a, int b, int c)
        {
            return b < c && b > a;
        }
    }
}
