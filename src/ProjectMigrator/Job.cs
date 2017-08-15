using ProjectMigrator.Source;

namespace ProjectMigrator
{
    public class Job
    {
        public string Name { get; set; }
        public SourceProject Source { get; set; }
        public TargetProject Target { get; set; }
    }
}
