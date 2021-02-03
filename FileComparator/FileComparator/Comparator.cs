using System.Collections.Generic;

namespace FileComparator
{
    public class Comparator
    {
        public static void PerformComparison(List<string> inputData, List<string> lookupData)
        {
            var missingItems = new List<string>();
            foreach (var input in inputData)
            {
                if (!lookupData.Contains(input))
                {
                    missingItems.Add(input);
                }
            }
            FileHelper.WriteFile(missingItems);
        }
    }
}
