using System;
using System.Collections.Generic;
using System.Text;

namespace Bam.Testing.Specification
{
    public class FeatureSetupFailedException : SpecTestFailedException
    {
        public FeatureSetupFailedException(string description) : base($"Feature ({description}") { }
    }
}
