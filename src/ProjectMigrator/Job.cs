using ProjectMigrator.Source;

namespace ProjectMigrator
{
    public class Job
    {
        public string Name { get; set; }
        public string SourceProjectFolder { get; set; }
        public SourceFilesCriteria Criteria { get; set; }
        public string TargetProjectFolder { get; set; }
    }
}
