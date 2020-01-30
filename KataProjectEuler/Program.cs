using KataProjectEuler.Interface;
using KataProjectEuler.Problems;
using System;

namespace KataProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //001
            IProblemResult _001 = new _001_MultiplesOf3and5();
            _001.GetResult();

            //002
            IProblemResult _002 = new _002_EvenFibonaccinumbers();
            _002.GetResult();

            //003
            IProblemResult _003 = new _003__LargestPprimeFactor();
            //_003.GetResult(); //Heavy CPU load

            //004
            IProblemResult _004 = new _004_LargestPalindromeProduct();
            _004.GetResult();

            //005
            IProblemResult _005 = new _005_SmallestMultiple();
            _005.GetResult();


            Console.WriteLine("End program!");
            Console.ReadKey();
        }
    }
}
