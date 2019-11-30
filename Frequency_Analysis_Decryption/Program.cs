using System;
using System.Collections.Generic;

namespace Frequency_Analysis_Decryption
{
    class Program
    {
        public static IDictionary<string, double> FrequencyAdd(IDictionary<string, double> keyValues)
        {
            keyValues.Add("а", 0.062);
            keyValues.Add("б", 0.014);
            keyValues.Add("в", 0.038);
            keyValues.Add("г", 0.013);
            keyValues.Add("д", 0.025);
            keyValues.Add("е", 0.072);
            keyValues.Add("ё", 0.072);
            keyValues.Add("ж", 0.007);
            keyValues.Add("з", 0.016);
            keyValues.Add("и", 0.062);
            keyValues.Add("й", 0.010);
            keyValues.Add("к", 0.028);
            keyValues.Add("л", 0.035);
            keyValues.Add("м", 0.026);
            keyValues.Add("н", 0.053);
            keyValues.Add("о", 0.090);
            keyValues.Add("п", 0.023);
            keyValues.Add("р", 0.040);
            keyValues.Add("с", 0.040);
            keyValues.Add("т", 0.053);
            keyValues.Add("у", 0.021);
            keyValues.Add("ф", 0.002);
            keyValues.Add("х", 0.009);
            keyValues.Add("ц", 0.004);
            keyValues.Add("ч", 0.012);
            keyValues.Add("ш", 0.006);
            keyValues.Add("щ", 0.003);
            keyValues.Add("ы", 0.016);
            keyValues.Add("ь", 0.014);
            keyValues.Add("ь", 0.014);
            keyValues.Add("э", 0.003);
            keyValues.Add("ю", 0.006);
            keyValues.Add("я", 0.018);
            keyValues.Add(" ", 0.175);
            return keyValues;
        }

        static void Main(string[] args)
        {
            var frequencyKeyValue = FrequencyAdd(new Dictionary<string, double>());
            
            

        }
    }
}
