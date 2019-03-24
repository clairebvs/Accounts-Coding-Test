using System; using System.Net; using Newtonsoft.Json;

namespace AccountsCodingTest.Models
{
    public class Account
    {         public Object getUserAccount()         {             string url = "https://frontiercodingtests.azurewebsites.net/api/accounts/getall";             var client = new WebClient();             var content = client.DownloadString(url);

            object jsonData = JsonConvert.DeserializeObject(content);             return jsonData;         }


        // Extension method used to add the middleware to the HTTP request pipeline.
        public static class AccountExtensions
    {
        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Account>();
        }
    }
}
