using ProjectMigrator.Copy;
using ProjectMigrator.Source;

namespace ProjectMigrator
{
    public class ProjectMigrator
    {
        public void Migrate(Job job)
        {
            var lister = new SourceFilesLister();
            var sourceFiles = lister.GetSourceFiles(job.Source.Criteria);

            var fileCopier = new FileCopier();
            var targetFiles = fileCopier.CopyFiles(sourceFiles, job.Source.ProjectFolder, job.Target.ProjectFolder);

        }
    }
}
