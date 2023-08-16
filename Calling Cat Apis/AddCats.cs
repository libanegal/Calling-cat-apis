using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Cat_Apis
{
    public class AddCats:IAddCats
    {
        public async Task<Cats> AddingCats(Cats catsResults) 
        {
            var newfact = new Datum()
            {
                fact = "1 year of a cats life is equal to 15 years of a humans life",
                length = 59,
            };
            var newfact1 = new Datum() 
            {
                fact = "Cats can jump up to six times their height",
                length = 42,
            };
            catsResults.data.Add(newfact);
            catsResults.data.Add(newfact1);       
            return catsResults;
        }

    }
}
