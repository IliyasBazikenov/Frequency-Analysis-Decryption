using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Frequency_Analysis_Decryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Some Path";
            string writePath = @"Some Path";
            Decoder decoder = new Decoder();
            var currentFrequency = decoder.ToDecode(path);
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    for(var i = 0; i < currentFrequency.Values.Count; i++)
                    {
                        sw.WriteLine(decoder.GetAlphabet()[i] + " - " + currentFrequency[decoder.GetAlphabet()[i]].ToString());
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
