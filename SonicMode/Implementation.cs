using MelonLoader;

namespace SonicMode;

internal sealed class Implementation : MelonMod
{
	public override void OnInitializeMelon()
	{
		Settings.Instance.AddToModSettings("Sonic Mode");
	}
}