using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Cat_Apis
{
    public class CatOrchestrator
    {
        private readonly ICatService _catService;
        private readonly ICatLogic _catLogic;
        private readonly IAddCats _addCats;
 
        public CatOrchestrator(ICatService catService, ICatLogic catLogic, IAddCats addCats)
        {
            _catService = catService;
            _catLogic = catLogic;
            _addCats = addCats;
        }

        public async Task<Cats> CompleteCatOrchestrate() 
        {
            var getCats = await _catService.GetCatServiceAsync();

            var catLogic = _catLogic.GroupFactLength(getCats);

            var addCats = _addCats.AddingCats(getCats);

            return  getCats;


        }
    }
}
