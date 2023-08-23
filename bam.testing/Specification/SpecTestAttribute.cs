/*
	Copyright © Bryan Apellanes 2015  
*/
using Bam.CommandLine;

namespace Bam.Testing.Specification
{

    [AttributeUsage(AttributeTargets.Method)]
    public class SpecTestAttribute : ConsoleActionAttribute
    {
    }
}
