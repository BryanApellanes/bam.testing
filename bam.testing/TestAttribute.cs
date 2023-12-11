using Bam.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Testing
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestAttribute : MenuItemAttribute
    {
        public TestAttribute(params TestType[] testType)
        {
            this.TypeTypes = testType;
        }

        public TestType[] TypeTypes { get; private set; }
    }
}
