using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CricDashboard
{
    class Program
    {
        private const string MatchesApi = @"https://dev132-cricket-live-scores-v1.p.mashape.com/matches.php";

        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            ProcessMatches().Wait();
        }

        private static async Task ProcessMatches() 
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("X-Mashape-Key", "FqzmWLJQnbmshVBmg2JAuIPHIEC1p1QckYLjsnCa2g0IkCNqlW");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var stringTask = client.GetStringAsync(MatchesApi);

            var msg = await stringTask;
            Console.Write(msg);
        } 
    }
}
