using Bam.CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Testing
{
    public class FailedTest
    {
        public ConsoleMethod Test { get; set; }
        public Exception Exception { get; set; }
    }
}
