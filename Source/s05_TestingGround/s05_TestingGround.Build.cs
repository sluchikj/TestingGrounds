// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class s05_TestingGround : ModuleRules
{
	public s05_TestingGround(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
