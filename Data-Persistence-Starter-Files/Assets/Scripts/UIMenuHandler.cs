using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenuHandler : MonoBehaviour {
	public string PlayerName { get; set; }

	// public void CheckName(string name) {
	// 	Debug.Log(name);
	// }

	public void Play() {
		if (GameManager.Instance == null)
			return;

		GameManager.Instance.playerName = PlayerName;
		SceneManager.LoadScene(1);
	}
}
