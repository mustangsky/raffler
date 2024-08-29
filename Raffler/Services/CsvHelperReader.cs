using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Raffler.Models;

namespace Raffler.Services
{
    public class CsvHelperReader : ICsvReader<List<CsvItemModel>>
    {
        public List<CsvItemModel> ReadCsv(string csvPath)
        {
            try
            {
                using (var reader = new StreamReader(csvPath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<CsvItemModel>().ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return default;
            }
        }
    }
}
