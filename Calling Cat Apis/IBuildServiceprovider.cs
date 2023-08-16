using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Cat_Apis
{
    public interface IBuildServiceprovider
    {
        ServiceProvider GetServiceProvider1(ServiceCollection singletonService);
        
    }
}
