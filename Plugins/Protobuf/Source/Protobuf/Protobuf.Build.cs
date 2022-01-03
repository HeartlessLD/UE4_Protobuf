// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class Protobuf : ModuleRules
{
	private string ModulePath
	{
		get { return ModuleDirectory; }
	}
	private string ThirdPartyPath
	{
		get { return Path.GetFullPath(Path.Combine(ModulePath, "../../ThirdParty")); }
	}
	public Protobuf(ReadOnlyTargetRules Target) : base(Target)
	{
	
	PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
	

		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
				Path.Combine(ThirdPartyPath, "include")
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
	
		PublicDefinitions.Add("GOOGLE_PROTOBUF_INTERNAL_DONATE_STEAL_INLINE");
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);

		PublicAdditionalLibraries.Add(Path.Combine(ThirdPartyPath, "lib/libprotobuf.lib"));
	}
}
