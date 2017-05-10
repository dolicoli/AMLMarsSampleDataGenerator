using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampledata
{
    class Program
    {
        static Random random = new Random();

        public static DateTime startDate = DateTime.Now.AddYears(100);
        public static string fmt = "00000000.##";
        static void Main(string[] args)
        {
            List<int> list = GenerateRandom(1032320);

            foreach(int i in list)
            {
                CSVModel model = new CSVModel();
                int dicemax = (int)(i / Math.Pow(10, (int)Math.Floor(Math.Log10(i))));
                //int dicemax = Convert.ToInt16(Math.Ceiling(d));
                switch (dicemax)
                {
                    case 1: model = generateCase1(i); break;
                    case 2: model = generateCase2(i); break;
                    case 3: model = generateCase3(i); break;
                    case 4: model = generateCase4(i); break;
                    case 5: model = generateCase5(i); break;
                    case 6: model = generateCase6(i); break;
                    case 7: model = generateCase7(i); break;
                }
                if (model.id != null)
                {
                    Console.WriteLine("Generating id : " + i);
                    WriteToCSV(model);
                }
            }
        }

        public static CSVModel generateCase1(int i)
        {
            CSVModel model = new CSVModel();
            Random rnd = new Random();
            int dice = rnd.Next(1, 10000);
            model.unixTime = DateTimeOffset.UtcNow.AddYears(100).AddSeconds(dice).ToUnixTimeMilliseconds().ToString();
            model.id = i.ToString(fmt);
            model.logMessage = "Informational || " + SeverityMessage.Case1();
            model.severity = 1;
            return model;
        }

        public static CSVModel generateCase2(int i)
        {
            CSVModel model = new CSVModel();
            model.unixTime = DateTimeOffset.UtcNow.AddYears(100).AddSeconds(i).ToUnixTimeMilliseconds().ToString();
            model.id = i.ToString(fmt);
            model.logMessage = "!" + i / 123213123 + "||" + SeverityMessage.Case2();
            model.severity = 2;
            return model;
        }

        public static CSVModel generateCase3(int i)
        {
            CSVModel model = new CSVModel();
            model.unixTime = DateTimeOffset.UtcNow.AddYears(100).AddSeconds(i).ToUnixTimeMilliseconds().ToString();
            model.id = i.ToString(fmt);
            model.logMessage = "!" + i / 1234322 + "|| XSXJ1123 " + SeverityMessage.Case3();
            model.severity = 3;
            return model;
        }

        public static CSVModel generateCase4(int i)
        {
            CSVModel model = new CSVModel();
            model.unixTime = DateTimeOffset.UtcNow.AddYears(100).AddSeconds(i).ToUnixTimeMilliseconds().ToString();
            model.id = i.ToString(fmt);
            model.logMessage = "!" + i / 12321 + "|| X1010 " + SeverityMessage.Case4();
            model.severity = 4;
            return model;
        }

        public static CSVModel generateCase5(int i)
        {
            CSVModel model = new CSVModel();
            model.unixTime = DateTimeOffset.UtcNow.AddYears(100).AddSeconds(i).ToUnixTimeMilliseconds().ToString();
            model.id = i.ToString(fmt);
            model.logMessage = "!" + i / 1123 + "|| X2323 " + SeverityMessage.Case5();
            model.severity = 5;
            return model;
        }

        public static CSVModel generateCase6(int i)
        {
            CSVModel model = new CSVModel();
            model.unixTime = DateTimeOffset.UtcNow.AddYears(100).AddSeconds(i).ToUnixTimeMilliseconds().ToString();
            model.id = i.ToString(fmt);
            model.logMessage = "!" + i / 3411323 + "|| " + SeverityMessage.Case6();
            model.severity = 6;
            return model;
        }

        public static CSVModel generateCase7(int i)
        {
            CSVModel model = new CSVModel();
            model.unixTime = DateTimeOffset.UtcNow.AddYears(100).AddSeconds(i).ToUnixTimeMilliseconds().ToString();
            model.id = i.ToString(fmt);
            model.logMessage = "!" + i/212123  + "|| " + SeverityMessage.Case5();
            model.severity = 6;
            return model;
        }


        public static List<int> GenerateRandom(int count)
        {
            // generate count random values.
            HashSet<int> candidates = new HashSet<int>();
            while (candidates.Count < count)
            {
                // May strike a duplicate.
                candidates.Add(random.Next());
            }

            // load them in to a list.
            List<int> result = new List<int>();
            result.AddRange(candidates);

            // shuffle the results:
            int i = result.Count;
            while (i > 1)
            {
                i--;
                int k = random.Next(i + 1);
                int value = result[k];
                result[k] = result[i];
                result[i] = value;
            }
            return result;
        }
        public static void WriteToCSV(CSVModel model)
        {
            string newFileName = "D:\\websites\\AzureML\\SampleDataGenerator\\sampledata\\ShipLog.csv";
            if (!File.Exists(newFileName))
            {
                string clientHeader = "unixTime" + "," + "id" + "," + "logMessage, severity" + Environment.NewLine;

                File.WriteAllText(newFileName, clientHeader);
            }
            List<string> modelstring = new List<string>();
            modelstring.Add(model.unixTime);
            modelstring.Add(model.id.ToString());
            modelstring.Add(model.logMessage);
            modelstring.Add(model.severity.ToString());
            File.AppendAllText(newFileName, string.Join(",", string.Join(",", modelstring) + Environment.NewLine));
        }
    }
}
