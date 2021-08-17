using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {
	public static GameManager Instance;
	public string playerName;

	[System.Serializable]
	public class HighscoreData {
		public int _points;
		public string _name;
	}

	public HighscoreData h_Data;

	private void Awake() {
		if (Instance != null) {
			Destroy(gameObject);
			return;
		}

		Instance = this;
		DontDestroyOnLoad(gameObject);

		LoadHighscore();
	}

	public void SaveHighscore(int points) {
		HighscoreData data = new HighscoreData();
		data._points = points;
		data._name = playerName;

		string json = JsonUtility.ToJson(data);

		File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
	}

	public void LoadHighscore() {
		string path = Application.persistentDataPath + "/savefile.json";
		if (File.Exists(path)) {
			string json = File.ReadAllText(path);
			h_Data = JsonUtility.FromJson<HighscoreData>(json);
		}
	}
}
