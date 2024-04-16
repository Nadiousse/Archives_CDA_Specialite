using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_numpy
{
    internal static class Numpy
    {
        public static List<int> Function(List<int> baseList, Func<int, int> condition)
        {
            List<int> result = new List<int>();

            foreach (int i in baseList)
            {
                result.Add(condition(i));
            }

            return result.ToList();
        }
    }
}
