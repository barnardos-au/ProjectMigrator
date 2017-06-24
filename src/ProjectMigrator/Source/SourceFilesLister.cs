using System.IO;
using System.Linq;
using ProjectMigrator.Common;

namespace ProjectMigrator.Source
{
    public class SourceFilesLister
    {
        public SourceFiles GetSourceFiles(SourceFilesCriteria criteria)
        {
            var files = Directory.EnumerateFiles(
                criteria.Path, criteria.SearchPattern, SearchOption.AllDirectories).ToList();

            if (criteria.IncludePaths != null)
            {
                files = files.Where(p => criteria.IncludePaths.Any(p.Contains)).ToList();
            }

            if (criteria.ExcludePaths != null)
            {
                files = files.Where(p => !criteria.ExcludePaths.Any(p.Contains)).ToList();
            }

            return new SourceFiles {Files = files.ToArray()};
        }
    }
}
