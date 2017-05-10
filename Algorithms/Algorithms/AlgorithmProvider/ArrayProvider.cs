using Algorithms.Helpers;
using Contract.AlgorithmProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AlgorithmProvider
{
    public class ArrayProvider : IArrayProvider
    {
        public ArrayProvider()
        {

        }

        public bool CanReachBoardGame(List<int> array)
        {
            int farthest = 0;
            for (int i = 0; i < array.Count && i <= farthest; i++)
            {
                farthest = farthest >= array[i] + i ? farthest : array[i] + i;
            }
            return farthest >= (array.Count - 1);
        }


        /// <summary>
        /// modifies an array so that all elements less than array[pivotIndex] appear first, then pivotValue
        /// and then all the greator ones.
        /// </summary>
        /// <param name="pivotIndex"></param>
        /// <param name="array"></param>
        public void DutchFlagPartition(int pivotIndex, List<int> array)
        {
            int pivotValue = array[pivotIndex];
            int smallIndex = 0, equalIndex = 0, largeIndex = array.Count - 1;

            while (equalIndex <= largeIndex)
            {
                if (pivotValue > array[equalIndex])
                {
                    array.Swap(smallIndex, equalIndex);
                    //AlgoHelper.SwapInt(ref array[smallIndex], ref array[equalIndex]);
                    smallIndex++;
                    equalIndex++;
                }
                else if (array[equalIndex] == pivotValue)
                {
                    equalIndex++;
                }
                else //if (array[equalIndex] > pivotValue)
                {
                    array.Swap(equalIndex, largeIndex);
                    //AlgoHelper.SwapInt(ref array[equalIndex], ref array[largeIndex]);
                    largeIndex--;
                }
            }
        }

        /// <summary>
        /// arrange same elements together, only 3 different types
        /// </summary>
        /// <param name="array"></param>
        public void DutchFlagPartitionV1(List<int> array)
        {            
            int first = 0, second = -1, third =  -1;

            for (int i = 1; i < array.Count; i++)
            {

                if (array[i] != array[first] && second == -1) //mark the second pointer
                {
                    second = i;
                }
                else if (array[i] != array[first] && array[i] != array[second] && third == -1)//mark the third pointer
                {
                    third = i;
                }
                else if (array[i] == array[first] && i == first + 1) //if first is same and the next one, then simply increment it
                {
                    first++;
                }
                else if (array[i] == array[second] && i == second + 1)
                {
                    second++;
                }
                else if (array[i] == array[third] && i == third + 1)
                {
                    third++;
                }
                else if (array[i] == array[first] && i > first + 1)
                {
                    array.Swap(i, second + 1);
                    array.Swap(second + 1, first + 1);
                    first++;
                    second++;
                    third++;
                }                
                else if (array[i] == array[second] && i > second + 1)
                {
                    array.Swap(i, second + 1);
                    second++;
                    third++;
                }                
                else
                {
                    //this will never be hit.
                }
            }            
        }

        /// <summary>
        /// this method simply separates all false with true, false should be first then true.
        /// </summary>
        /// <param name="array"></param>
        public void DutchFlagPartitionV3(List<bool> array)
        {
            int iFalse = -1, iTrue = -1;
            if (array[0])
            {
                iTrue = 0;
            }
            else
            {
                iFalse = 0;
            }

            for (int i = 1; i < array.Count; i++)
            {

                if (iFalse == -1 && !array[i])
                {
                    array.Swap(i, 0);
                    iFalse = 0;
                    iTrue++;
                }
                else if (iTrue == -1 && array[i])
                {
                    iTrue = i;
                }
                else if (array[i])
                {
                    array.Swap(i, iTrue + 1);
                    iTrue++;
                }
                else
                {
                    array.Swap(i, iFalse + 1);
                    iFalse++;
                }
            }
        }

        public void IncrementBigInt(List<int> array)
        {
            int carryFwd = 1;
            for (int i = array.Count - 1; i >= 0; i--)
            {
                if (carryFwd > 0 && array[i] < 9)
                {
                    array[i] += 1;
                    carryFwd = -1;
                }
                else if (carryFwd > 0 && array[i] == 9)
                {
                    array[i] = 0;
                    carryFwd = 1;
                }
                else 
                {
                    //do nothing as there is NO carryforward hence nothing to add                 
                }
            }
            if (carryFwd == 1)
            {
                array.Insert(0, 1);
            }
        }
    }
}
