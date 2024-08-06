using System.Net.Http.Headers;

namespace ISchoolAppWebAppIvan.Services
{
    public class DataRetrieval
    {
        // build a ethod to go get my data from my api...
        // we are going to send in the endpoint url ("about/" or "people/"...)
        public async Task<string> getData(String endpoint)
        {
            // Task vs Thread -
            // Task has async/await and a return value, can cancel a task
            // Thread no direct way to return from a thread, can do multiple things at once

            // using statement - at the end of it, it is automagically disposed...
            using (var client = new HttpClient())
            {
                // we have to set up our http client!
                // request/response
                client.BaseAddress = new Uri("Http://ischool.gccis.rit.edu/api/");
                // to clear out any previous stuff clean up
                client.DefaultRequestHeaders.Accept.Clear();
                // tell the server the type of file i'm looking for to come back
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage response = await client.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    // go get it...
                    var data = await response.Content.ReadAsStringAsync();
                    // data is a big string...
                    return data;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    return "HttpRequest" + msg;
                }
                catch (Exception e)
                {
                    var msg = e.Message;
                    return "Ex: " + msg;
                }
            }
        }
    }
}