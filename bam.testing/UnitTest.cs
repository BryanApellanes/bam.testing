using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Testing
{
    public class UnitTest : TestAttribute
    {
        public UnitTest() : base(TestType.Unit)
        { 
        }

        public bool Ignore => !string.IsNullOrEmpty(IgnoreBecause);

        public string IgnoreBecause { get; set; }
    }
}
