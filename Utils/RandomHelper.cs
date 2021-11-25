using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomStringGenerator;
using FizzWare.NBuilder;

namespace lioncs.Utils
{
    public class RandomHelper
    {
        public static string[] FIRST_NAMES = new string[]{
            "Jim", "Mike","Mark", "Tom", "Duncan","Luke", "John", 
            "Billy", "Rick" };

        public static string[] LAST_NAMES = new string[]{
            "Leon", "Hillis","Wilson", "Petrick", "Marunde","Lewis", "Johnson", 
            "Jackson", "Rose" };


        public static string getString(int length)
        {
            StringGenerator gen = new StringGenerator(0, 0, 0, 0, CharType.LowerCase);
            return gen.GenerateString(length);
        }

        public static string getPhrase(int wordCount){

            return getPhrase(wordCount, "");
        }

        public static string[] getPhrase(int howManyWords, int wordCount, string startWith)
        {
            string[] result = new string[howManyWords];
            for (int i = 0; i < howManyWords; i++)
            {
                result[i] = getPhrase(wordCount, startWith);
            }
            return result;
        }
        public static string getPhrase(int wordCount, string startWith)
        {
            RandomGenerator gen = new RandomGenerator();
            string[] words = gen.Phrase(1000).Split(' ');
            StringBuilder sb = new StringBuilder(startWith);
            for (int i = 0; i < wordCount; i++)
            {
                sb.Append(words[i]).Append(" ");
            }
            return sb.ToString().TrimEnd(' ');
        }

        public static string getFirstName()
        {
            RandomGenerator gen = new RandomGenerator();
            return FIRST_NAMES[gen.Next(0, FIRST_NAMES.Length)];
        }

        public static string getLastName()
        {
            RandomGenerator gen = new RandomGenerator();
            return LAST_NAMES[gen.Next(0, LAST_NAMES.Length)];
        }
    }

}
