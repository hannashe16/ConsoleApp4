using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 9, 6, 7, 8, 5 };
            int[] array2 = { 1, 2, 3, 4 };
            //SwapMinAndMaxValues(array);
            InvertArray(array2);
        }

        static void InvertArray(int[] array2)
        { 
            int firstElement = array2[0];
            int iFirstElement = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                firstElement = array2[i];
                iFirstElement = i;
            }

            Console.WriteLine(array2);

            /*while(iFirstElement < array2.Length)
            {
                
            }*/
        }
        
        /*static void SwapMinAndMaxValues(int[] array)
        {
          
            int minValue = array[0];
            int maxValue = array[0];
            int iMinValue = 0;
            int iMaxValue = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    iMinValue = i;
                }
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    iMaxValue = i;
                }
            }

            int container = array[iMinValue];
            array[iMinValue] = array[iMaxValue];
            array[iMaxValue] = container;

            Console.WriteLine(array);
        }*/
    }
}
