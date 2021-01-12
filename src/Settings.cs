using ModSettings;

namespace FurClothing
{
	internal class FurClothingModSettings : JsonModSettings
	{
		//Rabbitskin Hat Section
		[Section("Rabbitskin Hat")]
		[Name("Warmth")]
		[Description("Default is 2 Celcius")]
		[Slider(0f, 4f,41)]
		public float rabbitHatWarmth = 2f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5 Celcius")]
		[Slider(0f, 4f, 41)]
		public float rabbitHatWetWarmth = 1.5f;

		[Name("Windproofness")]
		[Description("Default is 1.5 Celcius")]
		[Slider(0f, 4f, 41)]
		public float rabbitHatWindproof = 1.5f;

		[Name("Protection")]
		[Description("Default is 4%")]
		[Slider(0f, 50f, 51)]
		public float rabbitHatProtection = 4f;

		[Name("Weight")]
		[Description("Default is .35 kg")]
		[Slider(0f, 2f, 41,NumberFormat = "{0:F2}")]
		public float rabbitHatWeight = .35f;


		//Rabbitskin Mitts Section
		[Section("Rabbitskin Mitts")]
		[Name("Warmth")]
		[Description("Default is 2 Celcius")]
		[Slider(0f, 4f, 41)]
		public float rabbitMittsWarmth = 2f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5 Celcius")]
		[Slider(0f, 4f, 41)]
		public float rabbitMittsWetWarmth = 1.5f;

		[Name("Windproofness")]
		[Description("Default is 2 Celcius")]
		[Slider(0f, 4f, 41)]
		public float rabbitMittsWindproof = 2f;

		[Name("Protection")]
		[Description("Default is 5%")]
		[Slider(0f, 50f, 51)]
		public float rabbitMittsProtection = 5f;

		[Name("Weight")]
		[Description("Default is 1 kg")]
		[Slider(0f, 2f, 41, NumberFormat = "{0:F2}")]
		public float rabbitMittsWeight = 1f;


		//Bearskin Coat Section
		[Section("Bearskin Coat")]
		[Name("Warmth")]
		[Description("Default is 6 Celcius")]
		[Slider(0f, 10f, 101)]
		public float bearCoatWarmth = 6f;

		[Name("Warmth When Wet")]
		[Description("Default is 5 Celcius")]
		[Slider(0f, 10f, 101)]
		public float bearCoatWetWarmth = 5f;

		[Name("Windproofness")]
		[Description("Default is 5 Celcius")]
		[Slider(0f, 10f, 101)]
		public float bearCoatWindproof = 5f;

		[Name("Protection")]
		[Description("Default is 18%")]
		[Slider(0f, 50f, 51)]
		public float bearCoatProtection = 18f;

		[Name("Weight")]
		[Description("Default is 5 kg")]
		[Slider(0f, 8f, 17)]
		public float bearCoatWeight = 5f;


		//Wolfskin Coat Section
		[Section("Wolfskin Coat")]
		[Name("Warmth")]
		[Description("Default is 4 Celcius")]
		[Slider(0f, 10f, 101)]
		public float wolfCoatWarmth = 4f;

		[Name("Warmth When Wet")]
		[Description("Default is 3 Celcius")]
		[Slider(0f, 10f, 101)]
		public float wolfCoatWetWarmth = 3f;

		[Name("Windproofness")]
		[Description("Default is 4 Celcius")]
		[Slider(0f, 10f, 101)]
		public float wolfCoatWindproof = 4f;

		[Name("Protection")]
		[Description("Default is 15%")]
		[Slider(0f, 50f, 51)]
		public float wolfCoatProtection = 15f;

		[Name("Weight")]
		[Description("Default is .35 kg")]
		[Slider(0f, 8f, 17)]
		public float wolfCoatWeight = 3f;


		//Moose-hide Cloak Section
		[Section("Moose-hide Cloak")]
		[Name("Warmth")]
		[Description("Default is 3.5 Celcius")]
		[Slider(0f, 10f, 101)]
		public float mooseCoatWarmth = 3.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 3 Celcius")]
		[Slider(0f, 10f, 101)]
		public float mooseCoatWetWarmth = 3f;

		[Name("Windproofness")]
		[Description("Default is 4 Celcius")]
		[Slider(0f, 10f, 101)]
		public float mooseCoatWindproof = 4f;

		[Name("Protection")]
		[Description("Default is 25%")]
		[Slider(0f, 50f, 51)]
		public float mooseCoatProtection = 25f;

		[Name("Weight")]
		[Description("Default is 4 kg")]
		[Slider(0f, 8f, 17)]
		public float mooseCoatWeight = 4f;


		//Deerskin Pants Section
		[Section("Deerskin Pants")]
		[Name("Warmth")]
		[Description("Default is 2 Celcius")]
		[Slider(0f, 4f, 41)]
		public float deerPantsWarmth = 2f;

		[Name("Warmth When Wet")]
		[Description("Default is 1.5 Celcius")]
		[Slider(0f, 4f, 41)]
		public float deerPantsWetWarmth = 1.5f;

		[Name("Windproofness")]
		[Description("Default is 1.5 Celcius")]
		[Slider(0f, 4f, 41)]
		public float deerPantsWindproof = 2f;

		[Name("Protection")]
		[Description("Default is 10%")]
		[Slider(0f, 50f, 51)]
		public float deerPantsProtection = 10f;

		[Name("Weight")]
		[Description("Default is 2 kg")]
		[Slider(0f, 4f, 41)]
		public float deerPantsWeight = 2f;


		//Deerskin Boots Section
		[Section("Deerskin Boots")]
		[Name("Warmth")]
		[Description("Default is 2.5 Celcius")]
		[Slider(0f, 4f, 41)]
		public float deerBootsWarmth = 2.5f;

		[Name("Warmth When Wet")]
		[Description("Default is 2 Celcius")]
		[Slider(0f, 4f, 41)]
		public float deerBootsWetWarmth = 2f;

		[Name("Windproofness")]
		[Description("Default is 2 Celcius")]
		[Slider(0f, 4f, 41)]
		public float deerBootsWindproof = 2f;

		[Name("Protection")]
		[Description("Default is 7%")]
		[Slider(0f, 50f, 51)]
		public float deerBootsProtection = 7f;

		[Name("Weight")]
		[Description("Default is 2 kg")]
		[Slider(0f, 4f, 41)]
		public float deerBootsWeight = 2f;
	}
	internal static class Settings
	{
		public static FurClothingModSettings options;
		public static void OnLoad()
		{
			options = new FurClothingModSettings();
			options.AddToModSettings("Fur Clothing Mod Settings");
		}
	}
}