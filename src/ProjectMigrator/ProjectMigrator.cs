using ProjectMigrator.Copy;
using ProjectMigrator.Source;

namespace ProjectMigrator
{
    public class ProjectMigrator
    {
        public void Migrate(Job job)
        {
            var lister = new SourceFilesLister();
            var sourceFiles = lister.GetSourceFiles(job.Criteria);

            var fileCopier = new FileCopier();
            var targetFiles = fileCopier.CopyFiles(sourceFiles, job.SourceProjectFolder, job.TargetProjectFolder);

        }
    }
}
