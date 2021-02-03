using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FileComparator
{
    public class FileHelper
    {
        public static readonly string ContentsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Contents");
        public static readonly string InputFile = Path.Combine(ContentsPath, "Input.txt");
        public static readonly string LookupFile = Path.Combine(ContentsPath, "Lookup.txt");
        public static readonly string OutputFile = Path.Combine(ContentsPath, "Output.txt");

        public static Tuple<List<string>, List<string>> ReadFile()
        {
            var inputData = LoadData(InputFile);
            var lookupData = LoadData(LookupFile);
            return Tuple.Create(inputData, lookupData);
        }

        public static void WriteFile(List<string> outputData)
        {
            File.WriteAllLines(OutputFile, outputData);
        }

        private static List<string> LoadData(string path)
        {
            var splitChar = new[] { ',', '\n', '\r', '\t' };
            var text = File.ReadAllText(path, Encoding.Default);

            if (!string.IsNullOrEmpty(text))
            {
                var data = text.Split(splitChar, StringSplitOptions.RemoveEmptyEntries).ToList();
                return data.Select(o => o.Trim()).ToList();
            }
            return null;
        }
    }
}
