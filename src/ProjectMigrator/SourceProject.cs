using ProjectMigrator.Source;

namespace ProjectMigrator
{
    public class SourceProject
    {
        public string ProjectFolder { get; set; }
        public SourceFilesCriteria Criteria { get; set; }
        public string Namespace { get; set; }
    }
}
