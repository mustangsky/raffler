using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raffler.Services
{
    public interface ICsvReader <T>
    {
        T ReadCsv(string csvPath);
    }
}
