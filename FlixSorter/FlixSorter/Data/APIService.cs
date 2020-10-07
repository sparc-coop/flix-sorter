using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FlixSorter.Data
{

    public class SearchResults
    {
        public List<MovieTV> Search { get; set; }
    }
    public class Item
    {
        public string Title { get; set; }
        public string Year { get; set; }
    }
    public class APIService
    {
        HttpClient Http = new HttpClient();

        public async Task<SearchResults> GetMediaByTitle(string search)
        {

            string key = "";
            string baseUrl = "http://www.omdbapi.com/?apikey=" + key;
            string apiUrl = baseUrl + "&s=" + search;
            var response = await Http.GetAsync(apiUrl);

            SearchResults results = new SearchResults();
            Item item = new Item();
            var jsonResponse = JsonConvert.DeserializeObject<SearchResults>(await response.Content.ReadAsStringAsync());
            //results.Search = jsonResponse;
            return jsonResponse;
        }
    }
    
}
