using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreConcepts.Pages.Services
{
    public interface IStocks
    {
        Task<List<StockInfo>> GetPrices(List<StockInfo> SList);
    }

    public class StockPrices : IStocks
    {
        public async Task<List<StockInfo>> GetPrices(List<StockInfo> SList)
        {
            foreach (StockInfo sinfo in SList)
            {
                string path =
               "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=" +
                sinfo.Symbol + "&apikey= C0RPL68JC9QTEBFRZ";
                sinfo.Price = double.Parse(await GetStockPriceAsync(path));
            }
            return SList;
        }
        static async Task<String> GetStockPriceAsync(string path)
        {
            //Product product = null;
            System.Net.Http.HttpClient client = new HttpClient();
            string price = "";
            HttpResponseMessage response = await client.GetAsync(path);
            var content = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                string[] parts = content.Split("\n");
                string pricePart = (from s in parts
                                    where s.IndexOf("price") >= 0
                                    select s).FirstOrDefault<string>();
                price = pricePart.Split(":")[1];
                price = price.Trim().Replace("\"", "").Replace(",", "");
            }
            return price;
        }

        private class HttpClient : System.Net.Http.HttpClient
        {
        }
    }

}
