using System;
using System.Collections.Generic;

namespace Algorithm.DataStructures
{
    public class Heap<T> : AlgorithmBase<T> where T : IComparable
    {
        public int Count => Items.Count;

        public Heap(IEnumerable<T> items)
        {
            Items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        private void Sort(int curentIndex, int maxLenght = -1)
        {
            int maxIndex = curentIndex;
            int leftIndex;
            int rightIndex;
            maxLenght = maxLenght == -1 ? Count : maxLenght;

            while (curentIndex < maxLenght)
            {
                leftIndex = 2 * curentIndex + 1;
                rightIndex = 2 * curentIndex + 2;

                if (leftIndex < maxLenght && Compare(Items[leftIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;
                }

                if (rightIndex < maxLenght && Compare(Items[rightIndex], Items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }

                if (maxIndex == curentIndex)
                {
                    break;
                }

                Swop(curentIndex, maxIndex);
                curentIndex = maxIndex;
            }
        }

        protected override void MakeSort()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                Swop(0, i);
                Sort(0, i);
            }
        }
    }
}
