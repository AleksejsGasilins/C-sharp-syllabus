using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        public static string link =
            @"E:\Programming\Studying\C-sharp-syllabus\csharp-basics\exercises\Collections\WordCount\lear.txt";

        static void Main(string[] args)
        {
            WordCount wordInfo = new WordCount(link);

            Console.WriteLine($"Lines = {wordInfo.GetLines(link)}");
            Console.WriteLine($"Words = {wordInfo.WordsCount(link)}");
            Console.WriteLine($"Chars = {wordInfo.NumberOfCharacters(link)}");
            
            Console.ReadKey();
        }
    }
}
