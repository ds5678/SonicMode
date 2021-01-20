using ModSettings;

namespace SonicMode
{
	internal class SonicModeSettings : JsonModSettings
	{
		[Name("Speed Multiplier")]
		[Slider(1f, 50f, 99)]
		public float speedMultiplier = 1f;
	}
	internal static class Settings
	{
		public static SonicModeSettings options;
		public static void OnLoad()
		{
			options = new SonicModeSettings();
			options.AddToModSettings("Sonic Mode");
		}
	}
}