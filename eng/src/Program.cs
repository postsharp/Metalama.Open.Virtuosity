// This is an open-source Metalama example. See https://github.com/postsharp/Metalama.Samples for more.

using PostSharp.Engineering.BuildTools;
using PostSharp.Engineering.BuildTools.Build;
using PostSharp.Engineering.BuildTools.Build.Model;
using PostSharp.Engineering.BuildTools.Build.Publishers;
using PostSharp.Engineering.BuildTools.Build.Solutions;
using PostSharp.Engineering.BuildTools.Dependencies.Model;
using Spectre.Console.Cli;
using System.Linq;

var product = new Product(Dependencies.MetalamaOpenVirtuosity)
{
    Solutions = new Solution[]
    {
        new DotNetSolution( "Metalama.Open.Virtuosity.sln" ) { CanFormatCode = true },
        new DotNetSolution( "src\\tests\\Metalama.Open.Virtuosity.TestApp\\Metalama.Open.Virtuosity.TestApp.sln" ) { IsTestOnly = true }
    },
    PublicArtifacts = Pattern.Create( "Metalama.Open.Virtuosity.$(PackageVersion).nupkg" ),
    Dependencies = new[] { Dependencies.PostSharpEngineering, Dependencies.Metalama },
    Configurations = Product.DefaultConfigurations
        .WithValue( BuildConfiguration.Public, new BuildConfigurationInfo(
            MSBuildName: "Release",
            RequiresSigning: true,
            PublicPublishers: Product.DefaultPublicPublishers.Add( new MergePublisher() ).ToArray() ) ) 
};

var commandApp = new CommandApp();

commandApp.AddProductCommands( product );

return commandApp.Run( args );