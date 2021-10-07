using KataProjectEuler.Interface;
using KataProjectEuler.Problems;
using System;
using System.Diagnostics;

namespace KataProjectEuler
{
    class Program
    {
        static void Main()
        {
            ////001
            //IProblemResult _001 = new _001_MultiplesOf3and5();
            //_001.GetResult();

            ////002
            //IProblemResult _002 = new _002_EvenFibonaccinumbers();
            //_002.GetResult();

            ////003
            //IProblemResult _003 = new _003__LargestPprimeFactor();
            ////_003.GetResult(); //Heavy CPU load

            ////004
            //IProblemResult _004 = new _004_LargestPalindromeProduct();
            //_004.GetResult();

            ////005
            //IProblemResult _005 = new _005_SmallestMultiple();
            //_005.GetResult();

            ////006
            //IProblemResult _006 = new _006_SumSquareDifference();
            //_006.GetResult();

            ////007
            //IProblemResult _007 = new _007_10001stPrime();
            //_007.GetResult();

            ////008
            //IProblemResult _008 = new _008__LargestProductInAseries();
            //_008.GetResult();

            ////009
            //IProblemResult _009 = new _009_SpecialPythagoreanTriplet();
            //_009.GetResult();

            ////010
            //IProblemResult _010 = new _010_SummationOfPrimes();
            //_010.GetResult();

            ////011
            //IProblemResult _011= new _011_LargestProductInAgrid();
            //_011.GetResult();

            //012
            //IProblemResult _012 = new _012_HighlyDivisibleTriangularNumber();
            //_012.GetResult();

            //013
            IProblemResult _013 = new _013_LargeSum();
            _013.GetResult();





            Console.WriteLine("End program!");
            Console.ReadKey();
        }
    }
}
