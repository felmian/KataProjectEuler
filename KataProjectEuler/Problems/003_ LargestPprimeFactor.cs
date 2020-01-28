using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?

    Основными факторами 13195 являются 5, 7, 13 и 29.
Что является самым большим основным фактором числа 600851475143?
 */
namespace KataProjectEuler.Problems
{
    class _003__LargestPprimeFactor : IProblemResult
    {
        private const long NUMBER = 6008514751437;

        public void GetResult()
        {
            List<int> fact = new List<int>();

            long i = NUMBER / 2;
            long sum = 1;

            for (long j = 1; j < i; j++)
            {
                if (NUMBER % j == 0)
                {
                    sum *= j;
                    if (sum == NUMBER)
                    {
                        return;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
/*
 *Congratulations, the answer you gave to problem 3 is correct.
You are the 468335th person to have solved this problem.

    Поздравляю, ответ, который вы дали на проблему 3, правильный.
Вы 468335 человек, который решил эту проблему.
 */
