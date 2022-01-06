using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTestUnits
{
    public class MaxArrayTestsScenarios : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            for (int size = 1; size < 10; size++)
            {
                int[,] arr = new int[size, size];
                int count = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        arr[i, j] = count++;
                    }
                }

                yield return new object[] { arr, count - 1 };
            }
        }
    }
}
