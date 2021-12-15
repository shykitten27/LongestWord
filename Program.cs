using System;
using System.Linq;
namespace LongestWord
{
    class Program
    {
        public static String LongestWord(string sen)
        {
            // code goes here  
            string[] words = sen.Split(" ");
            string[] sorted = words
                .OrderBy(x => x.Length)
                .ToArray();
            sen = sorted.ToString();
            return sen;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type your sentence and hit enter.");
            string sen = Console.ReadLine();
            LongestWord(sen);
            string[] words = sen.Split(" ");
            Console.WriteLine("The longest word is: " + words[0]);
        }
    }
}