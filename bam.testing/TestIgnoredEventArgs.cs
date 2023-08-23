using Bam.Testing.Unit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bam.Testing
{
    public class TestIgnoredEventArgs : EventArgs
    {
        public TestIgnoredEventArgs(UnitTestAttribute attribute)
        {
            Attribute = attribute;
        }

        public UnitTestAttribute Attribute { get; set; }
    }
}
