// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GamepadUMG : ModuleRules
{
	public GamepadUMG(ReadOnlyTargetRules Target) : base(Target)
	{
        PrivatePCHHeaderFile = "GamepadUMG.h";

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
		
		PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore", "UMG" });
		
	}
}
