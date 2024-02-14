using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSort
{
    public static class Sort<T>
    {
        public delegate int ComparisonDelegate(T x, T y);

        public static void BubbleSort(List<T> dataList, ComparisonDelegate comparison) 
        { 
            if(dataList == null || comparison == null)
            {
                throw new ArgumentNullException();
            }
            int n = dataList.Count;
            for (int i = 0; i< n-1; i++)
            {
                for (int j = 0; j< n-i-1; j++)
                {
                    if (comparison(dataList[j], dataList[j+1]) > 0)
                    {
                        T temp = dataList[j];
                        dataList[j] = dataList[j+1];
                        dataList[j+1] = temp;
                    }
                }
            }
        }
    }
}
