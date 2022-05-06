// Copyright (c) SharpCrafters s.r.o. All rights reserved.
// This project is not open source. Please see the LICENSE.md file in the repository root for details.

using PostSharp.Engineering.BuildTools;
using PostSharp.Engineering.BuildTools.Build.Model;
using PostSharp.Engineering.BuildTools.Build.Solutions;
using PostSharp.Engineering.BuildTools.Dependencies.Model;
using Spectre.Console.Cli;

var productDependencyDefinition = new DependencyDefinition( "Metalama.Open.Virtuosity", VcsProvider.GitHub, "Metalama" )
{
    CiBuildTypes = new ConfigurationSpecific<string>(
        "Metalama_MetalamaOpen_MetalamaOpenVirtuosity_DebugBuild",
        "Metalama_MetalamaOpen_MetalamaOpenVirtuosity_ReleaseBuild",
        "Metalama_MetalamaOpen_MetalamaOpenVirtuosity_PublicBuild" ),
    DeploymentBuildType = "Metalama_MetalamaOpen_MetalamaOpenVirtuosity_PublicDeployment",
    BumpBuildType = "Metalama_MetalamaOpen_MetalamaOpenVirtuosity_VersionBump"
};

var product = new Product(productDependencyDefinition)
{
    Solutions = new Solution[] { new DotNetSolution( "Metalama.Open.Virtuosity.sln" ) { CanFormatCode = true } },
    PublicArtifacts = Pattern.Create( "Metalama.Open.Virtuosity.sln.nupkg" ),
    Dependencies = new[] { Dependencies.PostSharpEngineering, Dependencies.Metalama },
    RequiresBranchMerging = true
};

var commandApp = new CommandApp();

commandApp.AddProductCommands( product );

return commandApp.Run( args );