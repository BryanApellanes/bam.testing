using Bam.Testing.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bam.Testing
{
    public class TestIgnoredEventArgs : EventArgs
    {
        public TestIgnoredEventArgs(UnitTest attribute)
        {
            Attribute = attribute;
        }

        public UnitTest Attribute { get; set; }
    }
}
