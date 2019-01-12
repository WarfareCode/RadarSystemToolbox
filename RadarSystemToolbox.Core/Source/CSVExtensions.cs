using System.Collections.Generic;
using System.IO;

namespace RadarSystemToolbox.Core
{
    public static class CSVExtensions
    {
        public static void WriteToCSVFile<T>(this IEnumerable<T> records, string path)
        {
            using (var sw = new StreamWriter(path))
            {
                var csvWriter = new CsvHelper.CsvWriter(sw);

                csvWriter.WriteRecords(records);
            }
        }
    }
}