using MelonLoader;
using UnityEngine;

namespace FasterSearching {

	internal class FasterSearchingMod : MelonMod {
		public override void OnApplicationStart() {
			Debug.Log($"[{InfoAttribute.Name}] version {InfoAttribute.Version} loaded!");
		}
	}
}
