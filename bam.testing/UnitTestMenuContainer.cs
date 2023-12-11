using Bam.Console;
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
    public class UnitTestMenuContainer : MenuContainer
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


        public virtual ServiceRegistry Configure(ServiceRegistry serviceRegistry) 
        {
            return serviceRegistry;
        }
    }
}
