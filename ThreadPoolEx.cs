using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class ThreadPoolEx
    {
        static void CheckHttpStatus(string url)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            Console.WriteLine($"The HTTP status code of {url} is {response.StatusCode}");

        }
       
    }
}
