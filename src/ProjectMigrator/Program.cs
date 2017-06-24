using System.IO;
using Mono.Options;
using ServiceStack;

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

            var job = File.ReadAllText(jobFile).FromJson<Job>();

            new ProjectMigrator().Migrate(job);
        }
    }
}