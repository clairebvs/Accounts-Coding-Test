using System; using System.Net; using Newtonsoft.Json;

namespace AccountsCodingTest.Models
{
    public class Account
    {
        public Object getUserAccount()         {             string url = "https://frontiercodingtests.azurewebsites.net/api/accounts/getall";             var client = new WebClient();             var content = client.DownloadString(url);

            object jsonData = JsonConvert.DeserializeObject(content);             return jsonData;         }
    }
}
