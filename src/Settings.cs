using ModSettings;

namespace SonicMode
{
	internal class SonicModeSettings : JsonModSettings
	{
		[Name("Movement Speed Multiplier")]
		[Description("Scales the speed at which the player moves when touching the ground.")]
		[Slider(1f, 5f, 41)]
		public float walkSpeedMultiplier = 1f;

		[Name("Sprint Speed Multiplier")]
		[Description("Scales the speed at which the player moves when sprinting.")]
		[Slider(1f, 50f, 99)]
		public float sprintSpeedMultiplier = 1f;

		[Name("Recharge Multiplier")]
		[Description("Scales the speed at which the stamina bar refills.")]
		[Slider(0.2f, 20f, 100)]
		public float rechargeScalar = 1f;

		[Name("Seconds before recovery scalar")]
		[Description("Scales the number of seconds before the stamina bar refills.")]
		[Slider(0f, 2f, 21)]
		public float secondsScalar = 1f;
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