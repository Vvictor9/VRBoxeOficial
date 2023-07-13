using UnrealBuildTool;

public class BoxeGameTarget : TargetRules
{
	public BoxeGameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("BoxeGame");
	}
}
