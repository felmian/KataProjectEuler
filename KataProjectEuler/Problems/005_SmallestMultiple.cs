using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

    2520 - это наименьшее число, которое можно разделить на каждое из чисел от 1 до 10 без остатка.
Какое наименьшее положительное число равномерно делится на все числа от 1 до 20?
 */
namespace KataProjectEuler.Problems
{
    class _005_SmallestMultiple : IProblemResult
    {
        public void GetResult()
        {
            int result = 0;
            int num = 1;
            int tmpI = 0;
            int maxDelitel = 20;
            while (result == 0)
            {

                for (int i = 1; i <= maxDelitel; i++)
                {
                    if (num % i != 0)
                        break;
                    tmpI = i;
                }
                if (tmpI == maxDelitel)
                    result = num;
                num++;
            }
            Console.WriteLine("5:   " + result);
        }
    }
}
/*
 * Congratulations, the answer you gave to problem 5 is correct.
You are the 422860th person to have solved this problem.
This problem had a difficulty rating of 5%. The highest difficulty rating you have solved remains at 5%.

    Поздравляю, ответ, который вы дали на проблему 5, правильный.
Вы 422860-й человек, который решил эту проблему.
Эта проблема имела оценку сложности 5%. Самый высокий уровень сложности, который вы решили, остается на уровне 5%.
 */
