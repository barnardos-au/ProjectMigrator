using System.IO;
using Mono.Options;
using Newtonsoft.Json;

namespace ProjectMigrator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string jobFile = null;

            new OptionSet
            {
                {"j|job=", "the path to to job file", o => jobFile = o}
            }.Parse(args);

            var text = File.ReadAllText(jobFile);
            var job = JsonConvert.DeserializeObject<Job>(text);

            new ProjectMigrator().Migrate(job);
        }
    }
}