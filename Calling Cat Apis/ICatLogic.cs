using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Cat_Apis
{
    public interface ICatLogic
    {
        Task<Cats> GroupFactLength(Cats catResults);
    }
}
