using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Histogram
{
    class СountingLikes
    {
        private string _path;

        public СountingLikes(string path)
        {
            _path = path;
        }

        public static List<int> GetNumbers(string path)
        {
            List<int> numsList = new List<int>();

            var readText = File.ReadAllLines(path);
            var nums = readText[0].Split(' ');

            foreach (var num in nums)
            {
                numsList.Add(int.Parse(num));
            }

            numsList.Sort();

            return numsList;
        }
    }
}
