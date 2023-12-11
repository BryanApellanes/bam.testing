﻿using Bam.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Testing
{
    /// <summary>
    /// Attribute used to addorn a class that contains unit tests.
    /// </summary>
    public class UnitTestMenu : MenuAttribute<UnitTest>
    {
        public UnitTestMenu() 
        {
            this.Selector = "ut";
        }

        public UnitTestMenu(string name) : base(name)
        {
            this.Selector = "ut";
        }
    }
}
