using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Frequency_Analysis_Decryption
{
    public class Decoder
    {
        private int GetLetterCount(string text, string substring)
        {
            return Regex.Matches(text, substring).Count; ;
        }

        public string[] GetAlphabet()
        {
            string lettersStr = "а,б,в,г,д,е,ё,ж,з,й,и,к,л,м,н,о,п,р,с,т,у,ф,х,ц,ч,ш,щ,ы,ъ,ь,э,ю,я";
            //string lettersStr = "ст,но,ен,то,на,ов,ни,ра,во,ко,сто,ено,нов,тов,ово,ова";
            return lettersStr.Split(",");
        }

        private IDictionary<string, double> GetCurrentFrequency(string text)
        {

            string[] letters = GetAlphabet();
            var analyzeResult = new Dictionary<string, double>();
            for (var i = 0; i < letters.Length; i++)
            {
                analyzeResult.TryAdd(letters[i], (double)GetLetterCount(text, letters[i]) / text.Length);
            }
            return analyzeResult; // letter and frequency
        }

        public IDictionary<string, double> ToDecode(string path)
        {
            var theorFrequency = FrequencyDictionary.GetTheorFrequency();
            var currentFrequency = GetCurrentFrequency(TextReader.ReadFromText(path));

            return currentFrequency;
        }
    }
}
