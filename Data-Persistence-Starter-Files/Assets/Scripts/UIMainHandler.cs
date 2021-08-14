using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIMainHandler : MonoBehaviour {

	public TMP_Text currentPlayerName;

	void Start() {
		if (GameManager.Instance != null)
			currentPlayerName.text = GameManager.Instance.playerName;
	}

	public void BackToMenu() {
		SceneManager.LoadScene(0);
	}
}
