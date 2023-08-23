﻿using Bam.CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Testing
{
    public interface ITeardownMethodProvider
    {
        List<ConsoleMethod> GetAfterAllMethods(Assembly assembly);
        List<ConsoleMethod> GetAfterEachMethods(Assembly assembly);
    }
}
