using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Microsoft.Build.Evaluation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace SanityCheck
{
    [TestClass]
    public class SanityCheck
    {
        [TestMethod]
        public void CheckCustom()
        {
            //var projectCollection = new ProjectCollection();
            var projFile = @"C:\Users\marshj\work\codeSeparationStrategyExample\CustomizedExample\CustomizedExample.csproj";
            //var project = projectCollection.LoadProject(projFile);
            //var projectReferences = project.GetItems("ProjectReference");

            //projectReferences.ShouldBeEmpty();
            XNamespace msbuild = "http://schemas.microsoft.com/developer/msbuild/2003";
            var projDefinition = XDocument.Load(projFile);
            var root = projDefinition
                .Element(msbuild + "Project");
            var references = root
                .Elements(msbuild + "ItemGroup")
                .Elements(msbuild + "ProjectReference")
                .Where(e => e != null)
                .Select(refElem => refElem.Attribute("Include")?.Value ?? string.Empty);
            references.Where(x => x.Contains("CoreExampleNuGet")).ShouldBeEmpty();
        }
    }
}
