using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Cat_Apis
{
    public class CatLogic: ICatLogic
    {
        public async Task<Cats> GroupFactLength(Cats catResults)
        {
            var c = new CatService();
            
            List<Datum> length = new List<Datum>();
            foreach (var cat in catResults.data)
            {
                if (cat.length < 26)
                {
                    length.Add(cat);

                }
            }
            return catResults;
        }
    }
}
