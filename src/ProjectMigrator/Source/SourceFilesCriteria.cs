namespace ProjectMigrator.Source
{
    public class SourceFilesCriteria
    {
        public string Path { get; set; }
        public string SearchPattern { get; set; }
        public string[] IncludePaths { get; set; }
        public string[] ExcludePaths { get; set; }
    }
}
