using Bam.Net;
using System;

namespace Bam.Testing
{
    public class UnitTestFailure
    {
        public UnitTestFailure()
        {
        }

        public UnitTestFailure(TestMethod testMethod, Exception ex)
        {
            TestMethod = testMethod;
            Exception = ex;
        }

        public UnitTestFailure(TestExceptionEventArgs testExceptionEventArgs)
        {
            this.CopyProperties(testExceptionEventArgs);
        }

        public Exception Exception { get; set; }
        public TestMethod TestMethod { get; set; }
    }
}