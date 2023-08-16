using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Cat_Apis
{
    public class BuildServiceprovider:IBuildServiceprovider
    {
        public  ServiceProvider GetServiceProvider1(ServiceCollection singletonService)
        {
            return singletonService.BuildServiceProvider();
        }
    }
}
