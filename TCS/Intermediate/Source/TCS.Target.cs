using UnrealBuildTool;

public class TCSTarget : TargetRules
{
	public TCSTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TCS");
	}
}
