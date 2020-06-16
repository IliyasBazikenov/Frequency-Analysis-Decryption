using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Frequency_Analysis_Decryption
{
    class TextReader
    {
        public static string ReadFromText(string path)
        {
            var textBuilder = new StringBuilder();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    textBuilder.Append(line);
                }
            }

            return textBuilder.ToString();
        }
    }
}
