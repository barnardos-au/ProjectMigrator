using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProjectMigrator.Common;

namespace ProjectMigrator.Copy
{
    public class FileCopier
    {
        public TargetFiles CopyFiles(SourceFiles sourceFiles, string sourceBaseFolder, string targetBaseFolder)
        {
            var targetFiles = new TargetFiles();
            var files = new List<string>();

            foreach (var copyJob in GetCopyJobs(sourceFiles, sourceBaseFolder, targetBaseFolder))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(copyJob.Target));
                File.Copy(copyJob.Source, copyJob.Target, true);
                files.Add(copyJob.Target);
            }

            targetFiles.Files = files.ToArray();

            return targetFiles;
        }

        private static IEnumerable<CopyJob> GetCopyJobs(SourceFiles sourceFiles, string sourceBaseFolder, string targetBaseFolder)
        {
            return from sourceFile in sourceFiles.Files
                   let relativePath = sourceFile.Replace(sourceBaseFolder, null)
                   let targetFile = PathCombine(targetBaseFolder, relativePath)
                   select new CopyJob {Source = sourceFile, Target = targetFile};
        }

        public static string PathCombine(string path1, string path2)
        {
            if (!Path.IsPathRooted(path2)) return Path.Combine(path1, path2);

            path2 = path2.TrimStart(Path.DirectorySeparatorChar);
            path2 = path2.TrimStart(Path.AltDirectorySeparatorChar);

            return Path.Combine(path1, path2);
        }
    }
}
