// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class UE4_Proto : ModuleRules
{
    private string ModulePath
    {
        get { return ModuleDirectory; }
    }
    public UE4_Proto(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Protobuf" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
        PublicIncludePaths.AddRange(
              new string[] {
				// ... add public include paths required here ...
				Path.Combine(ModuleDirectory, "proto")
              }
              );
        System.Console.WriteLine("-------------" + ModuleDirectory);
        // Uncomment if you are using Slate UI
        // PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        // Uncomment if you are using online features
        // PrivateDependencyModuleNames.Add("OnlineSubsystem");

        // To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
    }
}
