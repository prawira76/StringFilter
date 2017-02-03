using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFilter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listToFilter = new List<string>
            {
                "al",
                "albums",
                "aver",
                "bar",
                "barely",
                "be",
                "befoul",
                "bums",
                "by",
                "cat",
                "con",
                "convex",
                "ely",
                "foul",
                "here",
                "hereby",
                "jig",
                "jigsaw",
                "or",
                "saw",
                "tail",
                "tailor",
                "vex",
                "we",
                "weaver"
            };

            var filteredString = StringFilter.FilterStringList(listToFilter);
            foreach (var str in filteredString)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
