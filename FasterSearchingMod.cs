using MelonLoader;
using UnityEngine;

namespace FasterSearching {

	internal class FasterSearchingMod : MelonMod {
		public override void OnApplicationStart() {
			FasterSearchingSettings.Instance = new FasterSearchingSettings();
			FasterSearchingSettings.Instance.AddToModSettings("Faster Searching");
			Debug.Log($"[{InfoAttribute.Name}] version {InfoAttribute.Version} loaded!");
		}
	}
}
