using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._2023
{
    delegate bool CheckIntDel(int nun);
    delegate bool CheckDateDel(DateTime nun);
    delegate int UnarCountDel(int nun);
    delegate int ArrFind(int[] arr);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            CheckIntDel Even = delegate (int n) { return n % 2 == 0; };
            #endregion

            #region Task2
            UnarCountDel Square = delegate (int n) { return n * n; };
            #endregion

            #region Task3
            UnarCountDel Cube = delegate (int n) { return n * n * n; };
            #endregion

            #region Task4
            //CheckDateDel ProgDay = date => date.Month == 9 && date.Day == (DateTime.IsLeapYear(date.Year) ? 12 : 13);
            CheckDateDel ProgDay = date => date.DayOfYear == 256;
            #endregion

            #region Task5
            ArrFind MaxInArr = arr =>
            {
                int maxIndex = 0;
                int max = arr[maxIndex];
                for (int i = 1; i < arr.Length - 1; i++)
                    if (arr[i] > arr[maxIndex])
                    {
                        maxIndex = i;
                        max = arr[maxIndex];
                    }
                return maxIndex;
            };
            #endregion

            #region Task6
            ArrFind MinInArr = arr =>
            {
                int minIndex = 0;
                int min = arr[minIndex];
                for (int i = 1; i < arr.Length - 1; i++)
                    if (arr[i] < arr[minIndex])
                    {
                        minIndex = i;
                        min = arr[minIndex];
                    }
                return minIndex;
            };
            #endregion

            #region Task7
            ArrFind NotEvenArr = arr =>
            {
                int NotEvenCount = 0;
                foreach (int item in arr)
                    if (item % 2 != 0)
                        NotEvenCount++;
                return NotEvenCount;
            };
            #endregion
        }
    }
}
