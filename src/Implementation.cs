using MelonLoader;
using UnityEngine;

namespace FurClothing
{

	internal class FurClothingMod : MelonMod
	{

		public override void OnApplicationStart()
		{
			Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
			Settings.OnLoad();
		}
	}
}