using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StubTestHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseUrl = "http://localhost:9000";
            var stub = new HttpStubServer.HttpStub(baseUrl);

            stub.Start();

            //stub.Tell("/api/values", ask => "white");

            string line;
            do
            {
                line = Console.ReadLine();
                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseUrl + "/" + line).Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

            } while (!String.IsNullOrWhiteSpace(line));

            stub.Stop();

        }
    }
}
