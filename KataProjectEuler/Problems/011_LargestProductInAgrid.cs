using KataProjectEuler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * In the 20×20 grid below, four numbers along a diagonal line have been marked in red.
08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08
49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00
81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65
52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91
22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80
24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50
32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70
67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21
24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72
21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95
78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92
16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57
86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58
19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40
04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66
88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69
04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36
20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16
20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54
01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48
The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?

    В приведенной ниже сетке 20 × 20 четыре числа вдоль диагональной линии отмечены красным.
Произведение этих чисел составляет 26 × 63 × 78 × 14 = 1788696.
Каково наибольшее произведение четырех соседних чисел в одном направлении (вверх, вниз, влево, вправо или по диагонали) в сетке 20 × 20?
 */
namespace KataProjectEuler.Problems
{
    class SummaFourCoordinat
    {
        public int SummaCord { get; set; }
        public CoordEndValue First { get; set; }
        public CoordEndValue Seccond { get; set; }
        public CoordEndValue Third { get; set; }
        public CoordEndValue Last { get; set; }
    }
    class CoordEndValue
    {
        public int ValueCord { get; set; }
        public int X_cord { get; set; }
        public int Y_cord { get; set; }
    }
    class _011_LargestProductInAgrid : IProblemResult
    {
        private const int COUNT_NUMBER_FROM_GOUP = 4;
        int[,] EnterArray = new int[,]
            {
                 {08,02,22,97,38,15,00,40,00,75,04,05,07,78,52,12,50,77,91,08}
                ,{49,49,99,40,17,81,18,57,60,87,17,40,98,43,69,48,04,56,62,00}
                ,{81,49,31,73,55,79,14,29,93,71,40,67,53,88,30,03,49,13,36,65}
                ,{52,70,95,23,04,60,11,42,69,24,68,56,01,32,56,71,37,02,36,91}
                ,{22,31,16,71,51,67,63,89,41,92,36,54,22,40,40,28,66,33,13,80}
                ,{24,47,32,60,99,03,45,02,44,75,33,53,78,36,84,20,35,17,12,50}
                ,{32,98,81,28,64,23,67,10,26,38,40,67,59,54,70,66,18,38,64,70}
                ,{67,26,20,68,02,62,12,20,95,63,94,39,63,08,40,91,66,49,94,21}
                ,{24,55,58,05,66,73,99,26,97,17,78,78,96,83,14,88,34,89,63,72}
                ,{21,36,23,09,75,00,76,44,20,45,35,14,00,61,33,97,34,31,33,95}
                ,{78,17,53,28,22,75,31,67,15,94,03,80,04,62,16,14,09,53,56,92}
                ,{16,39,05,42,96,35,31,47,55,58,88,24,00,17,54,24,36,29,85,57}
                ,{86,56,00,48,35,71,89,07,05,44,44,37,44,60,21,58,51,54,17,58}
                ,{19,80,81,68,05,94,47,69,28,73,92,13,86,52,17,77,04,89,55,40}
                ,{04,52,08,83,97,35,99,16,07,97,57,32,16,26,26,79,33,27,98,66}
                ,{88,36,68,87,57,62,20,72,03,46,33,67,46,55,12,32,63,93,53,69}
                ,{04,42,16,73,38,25,39,11,24,94,72,18,08,46,29,32,40,62,76,36}
                ,{20,69,36,41,72,30,23,88,34,62,99,69,82,67,59,85,74,04,36,16}
                ,{20,73,35,29,78,31,90,01,74,31,49,71,48,86,81,16,23,57,05,54}
                ,{01,70,54,71,83,51,54,69,16,92,33,48,61,43,52,01,89,19,67,48}
            };
        public void GetResult()
        {
            List<SummaFourCoordinat> groupList = new List<SummaFourCoordinat>();

            groupList.AddRange(GetDataLeftRight()); //48477312
            groupList.AddRange(GetDataUpDown()); //51267216
            groupList.AddRange(GetDataDiagonal()); //32719995   //70600674

            SummaFourCoordinat maxGroupFromList = GetMaxGroupFromCurrentList(groupList);

            ShowSumFromKoordinat(maxGroupFromList);
        }

        private IEnumerable<SummaFourCoordinat> GetDataDiagonal()
        {
            int HeightArray = EnterArray.GetLength(0);  //y
            int WidthArray = EnterArray.GetLength(1);   //x
            List<SummaFourCoordinat> list = new List<SummaFourCoordinat>();

            for (int y = 0; y + COUNT_NUMBER_FROM_GOUP < HeightArray; y++)
                for (int x = 0; x + COUNT_NUMBER_FROM_GOUP <= WidthArray; x++)
                {
                    int sumGroup = 1;
                    sumGroup *= EnterArray[y, x];
                    sumGroup *= EnterArray[y + 1, x + 1];
                    sumGroup *= EnterArray[y + 2, x + 2];
                    sumGroup *= EnterArray[y + 3, x + 3];

                    list.Add(new SummaFourCoordinat
                    {
                        First = new CoordEndValue { ValueCord = EnterArray[y, x], X_cord = x, Y_cord = y },
                        Seccond = new CoordEndValue { ValueCord = EnterArray[y + 1, x + 1], X_cord = x + 1, Y_cord = y + 1 },
                        Third = new CoordEndValue { ValueCord = EnterArray[y + 2, x + 2], X_cord = x + 2, Y_cord = y + 2 },
                        Last = new CoordEndValue { ValueCord = EnterArray[y + 3, x + 3], X_cord = x + 3, Y_cord = y + 3 },
                        SummaCord = sumGroup
                    });
                }

            for (int y = 0; y + COUNT_NUMBER_FROM_GOUP < HeightArray; y++)
                for (int x = COUNT_NUMBER_FROM_GOUP - 1; x < WidthArray; x++)
                {
                    int sumGroup = 1;
                    sumGroup *= EnterArray[y, x];
                    sumGroup *= EnterArray[y + 1, x - 1];
                    sumGroup *= EnterArray[y + 2, x - 2];
                    sumGroup *= EnterArray[y + 3, x - 3];

                    list.Add(new SummaFourCoordinat
                    {
                        First = new CoordEndValue { ValueCord = EnterArray[y, x], X_cord = x, Y_cord = y },
                        Seccond = new CoordEndValue { ValueCord = EnterArray[y + 1, x - 1], X_cord = x - 1, Y_cord = y + 1 },
                        Third = new CoordEndValue { ValueCord = EnterArray[y + 2, x - 2], X_cord = x - 2, Y_cord = y + 2 },
                        Last = new CoordEndValue { ValueCord = EnterArray[y + 3, x - 3], X_cord = x - 3, Y_cord = y + 3 },
                        SummaCord = sumGroup
                    });
                }
            return list;
        }

        private IEnumerable<SummaFourCoordinat> GetDataUpDown()
        {
            int countgroupOnArray = EnterArray.GetLength(0) / COUNT_NUMBER_FROM_GOUP;
            int HeightArray = EnterArray.GetLength(0);  //y
            int WidthArray = EnterArray.GetLength(1);   //x
            List<SummaFourCoordinat> list = new List<SummaFourCoordinat>();

            for (int x = 0; x < WidthArray; x++)
                for (int y = 0; y + COUNT_NUMBER_FROM_GOUP <= HeightArray; y++)
                {
                    int sumGroup = 1;
                    sumGroup *= EnterArray[y, x];
                    sumGroup *= EnterArray[y + 1, x];
                    sumGroup *= EnterArray[y + 2, x];
                    sumGroup *= EnterArray[y + 3, x];

                    list.Add(new SummaFourCoordinat
                    {
                        First = new CoordEndValue { ValueCord = EnterArray[y, x], X_cord = x, Y_cord = y },
                        Seccond = new CoordEndValue { ValueCord = EnterArray[y + 1, x], X_cord = x, Y_cord = y + 1 },
                        Third = new CoordEndValue { ValueCord = EnterArray[y + 2, x], X_cord = x, Y_cord = y + 2 },
                        Last = new CoordEndValue { ValueCord = EnterArray[y + 3, x], X_cord = x, Y_cord = y + 3 },
                        SummaCord = sumGroup
                    });
                }
            return list;
        }

        private void ShowSumFromKoordinat(SummaFourCoordinat maxGroupFromList)
        {
            Console.WriteLine($"11:   {maxGroupFromList.SummaCord}\n" +
                              $"First(cord_x:{maxGroupFromList.First.X_cord}   cord_y:{maxGroupFromList.First.Y_cord}   value:{maxGroupFromList.First.ValueCord})\n" +
                              $"Seccond(cord_x:{maxGroupFromList.Seccond.X_cord}   cord_y:{maxGroupFromList.Seccond.Y_cord}   value:{maxGroupFromList.Seccond.ValueCord})\n" +
                              $"Third(cord_x:{maxGroupFromList.Third.X_cord}   cord_y:{maxGroupFromList.Third.Y_cord}   value:{maxGroupFromList.Third.ValueCord})\n" +
                              $"Last(cord_x:{maxGroupFromList.Last.X_cord}   cord_y:{maxGroupFromList.Last.Y_cord}   value:{maxGroupFromList.Last.ValueCord})\n");
        }

        private SummaFourCoordinat GetMaxGroupFromCurrentList(List<SummaFourCoordinat> groupList)
        {
            int index = 0;
            int max = groupList[index].SummaCord;
            for (int i = 1; i < groupList.Count; i++)
            {
                if (max < groupList[i].SummaCord)
                {
                    max = groupList[i].SummaCord;
                    index = i;
                }
            }
            return groupList[index];
        }

        private IEnumerable<SummaFourCoordinat> GetDataLeftRight()
        {
            int HeightArray = EnterArray.GetLength(0);  //y
            int WidthArray = EnterArray.GetLength(1);   //x
            List<SummaFourCoordinat> list = new List<SummaFourCoordinat>();

            for (int y = 0; y < HeightArray; y++)
                for (int x = 0; x + COUNT_NUMBER_FROM_GOUP <= WidthArray; x++)
                {
                    int sumGroup = 1;
                    sumGroup *= EnterArray[y, x];
                    sumGroup *= EnterArray[y, x + 1];
                    sumGroup *= EnterArray[y, x + 2];
                    sumGroup *= EnterArray[y, x + 3];

                    list.Add(new SummaFourCoordinat
                    {
                        First = new CoordEndValue { ValueCord = EnterArray[y, x], X_cord = x, Y_cord = y },
                        Seccond = new CoordEndValue { ValueCord = EnterArray[y, x + 1], X_cord = x + 1, Y_cord = y },
                        Third = new CoordEndValue { ValueCord = EnterArray[y, x + 2], X_cord = x + 2, Y_cord = y },
                        Last = new CoordEndValue { ValueCord = EnterArray[y, x + 3], X_cord = x + 3, Y_cord = y },
                        SummaCord = sumGroup
                    });
                }
            return list;
        }
    }
}
/*
 * Congratulations, the answer you gave to problem 11 is correct.
You are the 219662nd person to have solved this problem.
This problem had a difficulty rating of 5%. The highest difficulty rating you have solved remains at 5%. 
Return to Problems page.
 */
