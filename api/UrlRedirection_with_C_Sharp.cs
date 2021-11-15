using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Company.Function
{
    public static class UrlRedirection_with_C_Sharp
    {

        [FunctionName("UrlRedirection01")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "https://wonderful-mud-06286170f.azurestaticapps.net")] 
            HttpRequest req,
            ILogger log)
        {
            //log.LogInformation("C# HTTP trigger function processed a request.");

            //string name = req.Query["name"];

            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
           // dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

           // string responseMessage = string.IsNullOrEmpty(name)
           //     ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
           //     : $"Hello, {name}. This HTTP triggered function executed successfully.";

            //return new OkObjectResult(responseMessage);
            return new RedirectResult("https://www.gs1au.org/nlr", true);
        }
    }
}
