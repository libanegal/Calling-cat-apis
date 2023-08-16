using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Cat_Apis
{
    public class GetRequiredService
    {
        public IServiceProvider getRequiredService(ServiceProvider service1)
        {
            return (IServiceProvider)service1.GetRequiredService<ICatService>();
        }
    }
}
