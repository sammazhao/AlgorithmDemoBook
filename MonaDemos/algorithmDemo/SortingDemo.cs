using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonaDemos.algorithmDemo
{
    public class SortingDemo
    {
        //冒泡排序
        public List<int> BubbleSorting(List<int> listOriginal)
        {
            if (listOriginal.Count == 1)
            {
                return listOriginal;
            }
            else
            {
                for (int i = 0; i < listOriginal.Count() - 1; i++)
                {
                    for (int k = 0; k < listOriginal.Count() - 1 - i; k++)
                    {
                        int tmp = 0;
                        if (listOriginal[k] > listOriginal[k + 1])
                        {
                            tmp = listOriginal[k + 1];
                            listOriginal[k + 1] = listOriginal[k];
                            listOriginal[k] = tmp;
                        }
                    }
                }

                return listOriginal;
            }
        }

        //快速排序
        //它的基本思想是：通过一趟排序将要排序的数据分割成独立的两部分，其中一部分的所有数据都比另外一部分的所有数据都要小，然后再按此方法对这两部分数据分别进行快速排序，整个排序过程可以递归进行，以此达到整个数据变成有序序列
        static void QuickSort(ref List<int> nums, int left, int right)
        {
            if (left < right)
            {
                int i = left;
                int j = right - 1;
                int middle = nums[(left + right) / 2];
                while (true)
                {
                    while (i < right && nums[i] < middle) { i++; };
                    while (j > 0 && nums[j] > middle) { j--; };
                    if (i == j) break;
                    int tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;
                    if (nums[i] == nums[j]) j--;
                }
                QuickSort(ref nums, left, i);
                QuickSort(ref nums, i + 1, right);
            }
        }
    }
}
