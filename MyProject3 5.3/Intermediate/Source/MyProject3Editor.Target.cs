using UnrealBuildTool;

public class MyProject3EditorTarget : TargetRules
{
	public MyProject3EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MyProject3");
	}
}
