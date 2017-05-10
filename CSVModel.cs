using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampledata
{
    public class CSVModel
    {
        public string unixTime { get; set; }
        public string id { get; set; }
        public string logMessage { get; set; }
        public int severity { get; set; }
    }
}
