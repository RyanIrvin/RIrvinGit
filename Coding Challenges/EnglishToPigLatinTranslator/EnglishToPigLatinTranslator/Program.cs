using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishToPigLatinTranslator
{
    class Program
    {
        const string Vowels = "aeiouAEIOU";

        static void Main(string[] args)
        {
            /*
            Pig latin has two very simple rules.

            If a word starts with a consonant move the first letter(s) of the word, till you reach a vowel, to the end of the word and add "ay" to the end.
            have ➞ avehay
            cram ➞ amcray
            take ➞ aketay
            cat ➞ atcay
            shrimp ➞ impshray
            trebuchet ➞ ebuchettray
            If a word starts with a vowel add "yay" to the end of the word.

            ate ➞ ateyay
            apple ➞ appleyay
            oaken ➞ oakenyay
            eagle ➞ eagleyay
            Write two functions to make an english to pig latin translator. The first function string TranslateWord(string word) takes a single word and returns that word translated into pig latin.
            The second function string TranslateSentence(string sentence) takes an english sentince and returns that sentence translated into pig latin.

            Examples
            TranslateWord("flag") ➞ "agflay"

            TranslateWord("card") ➞ "ardcay"

            TranslateWord("button") ➞ "uttonbay"

            TranslateWord("") ➞ ""

            TranslateWord(null) ➞ ""

            TranslateSentence("I like to eat honey waffles.") ➞ "Iyay ikelay otay eatyay oneyhay afflesway."

            TranslateSentence("Do you think it is going to rain today?") ➞ "Oday youyay inkthay ityay isyay oinggay otay ainray odaytay?"
            */

            
            string myString = "Do you think it is going to rain today?";

            Console.WriteLine(TranslateSentence(myString));
            Console.ReadKey();
        }

        public static string TranslateSentence(string sentence)
        {
            StringBuilder sbSentence = new StringBuilder();
            string[] words = sentence.Split(' ');

            foreach (string word in words)
                sbSentence.Append(TranslateWord(word) + " ");

            string answer = sbSentence.ToString().ToLower();

            return char.ToUpper(answer[0]) + answer.Substring(1);  //Capitalize first letter and return the rest
        }

        public static string TranslateWord(string word)
        {
            StringBuilder sbWord = new StringBuilder();
            StringBuilder sbPunctuation = new StringBuilder();
            bool wordStartsWithVowel = Vowels.Contains(word[0]);
            bool wordEndsWithPunctuation = Char.IsPunctuation(word[word.Length - 1]);

            if(wordEndsWithPunctuation) // Check if string ends with punctuation, if so store the value
            {
                sbPunctuation.Append(word[word.Length - 1]);
            }

            if(wordEndsWithPunctuation)
            {
                if (wordStartsWithVowel)
                    sbWord.Append(word.Replace(sbPunctuation.ToString(), "") + "yay" + sbPunctuation); // remove punctuation from original string and add it after to keep it's place at end of sentence
                else
                {
                    int firstVowelIndex = FindVowelIndex(word);
                    sbWord.Append(word.Replace(sbPunctuation.ToString(), "").Substring(firstVowelIndex) + word.Substring(0, firstVowelIndex) + "ay" + sbPunctuation); // remove punctuation from original string and add it after to keep it's place at end of sentence
                }
            }
            else
            {
                if (wordStartsWithVowel)
                    sbWord.Append(word + "yay");
                else
                {
                    int firstVowelIndex = FindVowelIndex(word);
                    sbWord.Append(word.Substring(firstVowelIndex) + word.Substring(0, firstVowelIndex) + "ay");
                }
            }

            return sbWord.ToString().Trim();
        }

        public static int FindVowelIndex(string word)
        {
            for (int i = 0; i < word.Length; i++)
                if (Vowels.Contains(word[i]))
                    return i;

            return -1;
        }
    }
}
