using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  EN
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
    RU
    Палиндромное число читается одинаково в обоих направлениях. Самый большой палиндром, полученный из произведения двух двузначных чисел, равен 9009 = 91 × 99.
Найдите самый большой палиндром из двух трехзначных чисел.
 */
namespace KataProjectEuler.Problems
{
    class _004_LargestPalindromeProduct : IProblemResult
    {
        public void GetResult()
        {
            int maxPolondrom = 0;
            int start = 100;
            int end = 1000;
            for (int i = start; i < end; i++)
            {
                for (int j = start; j < end; j++)
                {
                    int proizv = i * j;
                    if (IsPolindrom(proizv))
                    {
                        if (proizv > maxPolondrom)
                            maxPolondrom = proizv;
                    }
                }
            }
            Console.WriteLine("Max polindrom = " + maxPolondrom);
        }
        private bool IsPolindrom(int v)
        {
            string str = v.ToString();
            if (str.Length % 2 == 0)
            {
                string newStr = str.Substring(str.Length / 2);
                string strStart = str.Replace(newStr, "");
                newStr = SwapStr(newStr);
                if (strStart == newStr)
                    return true;
            }
            return false;
        }
        private string SwapStr(string newStr)
        {
            string strSwap = "";
            for (int i = newStr.Length - 1; i >= 0; i--)
            {
                strSwap += newStr[i].ToString();
            }
            return strSwap;
        }
    }
}
/*
 * Congratulations, the answer you gave to problem 4 is correct.
You are the 415520th person to have solved this problem.
This problem had a difficulty rating of 5%. The highest difficulty rating you have solved remains at 5%. 

    
   Поздравляю, ответ, который вы дали на проблему 4, правильный.
Вы 415520-й человек, который решил эту проблему.
Эта проблема имела оценку сложности 5%. Самый высокий уровень сложности, который вы решили, остается на уровне 5%.
 */
