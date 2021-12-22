using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class WordCount
    {
        private string _path;

        public WordCount(string path)
        {
            _path = path;
        }
        public int GetLines(string link)
        {
            int count = 0;

            using (StreamReader reader = File.OpenText(link))
            {
                while (reader.ReadLine() != null)
                { 
                    count++;
                }

                return count;
            }
        }

        public int WordsCount(string link)
        {
            StreamReader sr = new StreamReader(link);

            int counter = 0;
            string delim = " ',."; 
            string[] fields = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;
            }
            sr.Close();
            return counter;
        }

        public int NumberOfCharacters(string link)
        {
            var numberOfCharacters = File.ReadAllLines(link).Sum(s => s.Length);
            return numberOfCharacters;
        }
    }
}
