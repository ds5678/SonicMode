namespace SonicMode;

[TheLongDarkMods.ModClass]
internal sealed partial class Implementation
{
	public override void OnInitializeMelon()
	{
		Settings.Instance.AddToModSettings("Sonic Mode");
	}
}