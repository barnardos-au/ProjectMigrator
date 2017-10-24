using System.IO;
using Mono.Options;
using Newtonsoft.Json;

namespace ProjectMigrator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //string jobFile = null;

            //new OptionSet
            //{
            //    {"j|job=", "the path to to job file", o => jobFile = o}
            //}.Parse(args);

            var logicJobJson = File.ReadAllText(@"C:\code\barnardos-au\ProjectMigrator\src\Examples\mystory.logic.json");
            var logicJob = JsonConvert.DeserializeObject<Job>(logicJobJson);
            new ProjectMigrator().Migrate(logicJob);

            var modelsJobJson = File.ReadAllText(@"C:\code\barnardos-au\ProjectMigrator\src\Examples\mystory.domain.models.json");
            var modelsJob = JsonConvert.DeserializeObject<Job>(modelsJobJson);
            new ProjectMigrator().Migrate(modelsJob);
        }
    }
}