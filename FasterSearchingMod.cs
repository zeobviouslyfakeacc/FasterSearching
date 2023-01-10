using MelonLoader;
using UnityEngine;

namespace FasterSearching {

	internal class FasterSearchingMod : MelonMod {
		public override void OnInitializeMelon() {
			FasterSearchingSettings.Instance = new FasterSearchingSettings();
			FasterSearchingSettings.Instance.AddToModSettings("Faster Searching");
			Debug.Log($"[{Info.Name}] version {Info.Version} loaded!");
		}
	}
}
