using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pathToSolution = @"C:\code\mystory\MyStory\MyStory.V2.sln";
            const string projectName = "Logic";

            // start Roslyn workspace
            var workspace = MSBuildWorkspace.Create();

            // open solution we want to analyze
            var solutionToAnalyze =
                workspace.OpenSolutionAsync(pathToSolution).Result;

            var project =
                solutionToAnalyze.Projects
                    .Where((proj) => proj.Name == projectName)
                    .FirstOrDefault();

            var sampleToAnalyzeCompilation =
                project.GetCompilationAsync().Result;

            string classFullName = "MyStory.Logic.Common.Models.Registration";

            // getting type out of the compilation
            INamedTypeSymbol simpleClassToAnalyze =
                sampleToAnalyzeCompilation.GetTypeByMetadataName(classFullName);

            //var resUnitDoc = project.Documents
            //    .Where(p => p.Name == "ResidentialUnit.cs")
            //    .FirstOrDefault();

            //resUnitDoc.

        }
    }
}
