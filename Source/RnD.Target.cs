// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RnDTarget : TargetRules
{
	public RnDTarget(TargetInfo Target) : base(Target) //RnDTarget(TargetInfo Target)
	{
		Type = TargetType.Game;
        // Type = TargetType.Server;
       // UEBuildConfiguration.bCompileSteamOSS = true;
        bUsesSteam = true;

        ExtraModuleNames.AddRange(new string[] { "RnD" });
    }
}
