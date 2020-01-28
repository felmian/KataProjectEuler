using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.

    Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. Сумма этих чисел равна 23.
Найдите сумму всех чисел меньше 1000, кратных 3 или 5.

 */

namespace KataProjectEuler.Problems
{
    class _001_MultiplesOf3and5: IProblemResult
    {
        public void GetResult()
        {
            int length = 1000;
            int summa = 0;
            for (int i = 0; i < length; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    summa += i;
            }
            Console.WriteLine(summa);
        }
    }
}


/*
 * Congratulations, the answer you gave to problem 1 is correct.
You are the 818552nd person to have solved this problem.
This problem had a difficulty rating of 5%. The highest difficulty rating you had previously solved was 0%. 
This is a new record. Well done!


    Поздравляю, ответ, который вы дали на проблему 1, правильный.
Вы 818552-й человек, который решил эту проблему.
Эта проблема имела оценку сложности 5%. Наивысшая оценка сложности, которую вы ранее решали, составила 0%.
Это новая запись. Отлично сработано!
 */
