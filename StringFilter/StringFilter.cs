using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFilter
{
    public class StringFilter
    {
        public const int NrCharsToPass = 6;

        public static IList<string> FilterStringList(IList<string> list)
        {
            // We could use a StringBuilder to store the result.
            //  This would reduce the memory usage a little bit, but would complicate the code a lot more
            //  Another option is to update the inputparameter. Remove all the strings that don't pass the filter and return it
            var result = new List<string>();

            if (list == null || list.Count == 0)
                return result;

            for (var i = 0; i < list.Count; i++)
            {
                var str1 = list[i];

                // No need to traverse the entire list, start with i + 1
                for (var j = i + 1; j < list.Count; j++)
                {
                    var str2 = list[j];
                    if (str1.Length + str2.Length == NrCharsToPass)
                    {
                        result.Add(str1 + str2);
                        result.Add(str2 + str1);
                    }
                }
            }

            // We could write this as result.Where(list.Contains).ToList()
            //  but I find this more readable
            return result.Where(str => list.Contains(str)).ToList();
        }
    }
}
