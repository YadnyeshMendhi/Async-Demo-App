using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Async_demo_app
{
    class SysDotNetNamespaceEx
    {
        static void Main(string[] args)
        {
            //string apiUrl = "";

            try
            {
                //Create a web class instance to send HTTP request
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add(".NET", "ConsoleApp 5.0");

                    //send an http get request to specified url  and get response
                    string response = webClient.DownloadString("http://35.154.128.4:1139/123");

                    Console.WriteLine("Response from the server: ");
                    Console.WriteLine(response);
                }
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse httpWebResponse)
                {
                    Console.WriteLine($"Http error : {httpWebResponse.StatusCode} - {httpWebResponse.StatusDescription}");
                }
                else
                {
                    Console.WriteLine("Error occured : "+ex.Message);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error occured  "+ex.Message);
            }

            Console.ReadLine();
        }
    }
}
