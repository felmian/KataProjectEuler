using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10 001st prime number?

    Перечисляя первые шесть простых чисел: 2, 3, 5, 7, 11 и 13, мы видим, что шестое простое число равно 13.
Что такое 10 001-е простое число?
 */

namespace KataProjectEuler.Problems
{
    class _007_10001stPrime:IProblemResult
    {
        const int MAX_NUM = 10001;  //максимальное число до которого искать

        public void GetResult()
        {
            long maxCounter = 0;    //ряд чисел
            int sumator = 0;    //количество найденных простых чисел
            int i;
            while (sumator < MAX_NUM)
            {
                maxCounter++;
                for (i = 1; i <= maxCounter / 2; i++)
                {
                    if (maxCounter % (i + 1) == 0)
                    {
                        if (maxCounter != (i + 1))
                            break;
                    }
                    if (maxCounter / 2 == i)
                    {
                        sumator++;
                        //Console.WriteLine($"Число {maxCounter} позиция {sumator}");
                    }
                }
            }
            Console.WriteLine("7:   " + maxCounter);
        }
    }
}
/*
 * Congratulations, the answer you gave to problem 7 is correct.
You are the 363923rd person to have solved this problem.
This problem had a difficulty rating of 5%. The highest difficulty rating you have solved remains at 5%. 

    Поздравляю, ответ, который вы дали на проблему 7, правильный.
Вы 363923-й человек, который решил эту проблему.
Эта проблема имела оценку сложности 5%. Самый высокий уровень сложности, который вы решили, остается на уровне 5%.
 */
