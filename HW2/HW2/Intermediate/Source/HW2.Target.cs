using UnrealBuildTool;

public class HW2Target : TargetRules
{
	public HW2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HW2");
	}
}
