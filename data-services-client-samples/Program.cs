using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Quadient.DataServices.Api;
using Quadient.DataServices.Api.Address;
using Quadient.DataServices.Api.Country;
using Quadient.DataServices.Api.Job;
using Quadient.DataServices.Model;
using Quadient.DataServices.Model.Address;

namespace Quadient.DataServices.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Args are missing args[0] Company args[1] Username args[2] Password");
            }

            var creds = new Credentials
            {
                Company = args[0],
                Username = args[1],
                Password = args[2]
            };

            var correction = new AddressCorrection(new List<CorrectionRequestAddress>
            {
                new CorrectionRequestAddress("Quadient", new List<string> {"1301 5th Ave.", " Ste. 1301" }, "Seattle", null, "WA", "98100", "US"),
                new CorrectionRequestAddress("Starbucks", new List<string> {"2501 Utah Ave. S.", "Ste. 800"}, "Seattle", null, "WA", "98134", "US")

            });
            var standardization = new CountryStandardization(new List<string> {"United States", "United Kingdom"});
            var standardization2 = new CountryStandardization(new List<string> {"Danmark", "Holland"});

            Task.Run(async () =>
            {
                Console.WriteLine("Running address correction sample 1");
                var client = new Client(creds);
                var resp = await client.Execute(correction);
                Console.WriteLine($"address correction sample 1 output\n {resp.ToJson()}");

                Console.WriteLine("Running address correction sample 2, JobSession");
                using(var session = await client.CreateJob())
                {
                    Console.WriteLine($"JobId {session.JobId}");
                    var resp2 = await session.Execute(correction);
                    Console.WriteLine($"address correction sample 2 output\n {resp2.ToJson()}");
                    Console.WriteLine("Running country standardization sample 1 and 2 in session");
                    var resp3 = await session.Execute(standardization);
                    Console.WriteLine($"standardization sample 1 output\n {resp3.ToJson()}");
                    var resp4 = await session.Execute(standardization2);
                    Console.WriteLine($"standardization sample 2 output\n {resp4.ToJson()}");

                    var jobSummary = await session.Execute(new GetJob(session.JobId));
                    Console.WriteLine($"job summary output\n {jobSummary.ToJson()}");

                    Console.WriteLine($"Finished JobSession {session.JobId}");
                }
            }).GetAwaiter().GetResult();
            Console.ReadLine();
        }
    }
}
