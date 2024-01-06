﻿using Bam.Console;
using Bam.Net.CoreServices;
using Bam.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Testing
{
    [UnitTestMenu()]
    public abstract class UnitTestMenuContainer : MenuContainer
    {
        /// <summary>
        /// Create a new UnitTestMenuContainer using the specified dependency provider.
        /// </summary>
        /// <param name="serviceRegistry"></param>
        public UnitTestMenuContainer(ServiceRegistry serviceRegistry)
            : base() 
        {
            this.SetDependencyProvider(this.Configure(serviceRegistry));
        }

        /// <summary>
        /// Configures the specified service registry before setting as the DependencyProvider property.
        /// </summary>
        /// <param name="serviceRegistry">The service registry.</param>
        /// <returns>ServiceRegistry</returns>
        public virtual ServiceRegistry Configure(ServiceRegistry serviceRegistry) 
        {
            return serviceRegistry;
        }
    }
}
