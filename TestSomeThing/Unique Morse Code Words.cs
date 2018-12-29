using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestSomeThing
{
    public class Unique_Morse_Code_Words
    {
        public Unique_Morse_Code_Words()
        {

        }

        public int UniqueMorseRepresentations(string[] words)
        {
            var signals = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            var characters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };

            var mapDic = new Dictionary<char, string>();

            for (int i = 0; i < signals.Length; i++)
            {
                mapDic[characters[i]] = signals[i];
            }

            var resultDic = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var mapWord = string.Empty;

                foreach(char character in word)
                {
                    mapWord += mapDic[character];
                }

                resultDic[mapWord] = 0;
            }

            return resultDic.Keys.Count;
        }
    }
}
