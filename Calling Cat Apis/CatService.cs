using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Calling_Cat_Apis
{
    public class CatService:ICatService
    {
       
        public async Task<string> GetCatServiceAsync()
        {
            var _httpClient = new HttpClient();
            var requestMessage = new HttpRequestMessage();
            requestMessage.RequestUri = new Uri("https://catfact.ninja/facts?max_length=50&limit=7");
            var json = await _httpClient.SendAsync(requestMessage);
            var result = await json.Content.ReadAsStringAsync();
            var catobject = JsonConvert.DeserializeObject<Cats>(result);
            Console.WriteLine(result);
            return result;
        }
       
    }    
}
