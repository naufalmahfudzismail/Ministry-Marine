using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	public Text txHighScore;
	int highscore;
	// Use this for initialization
	void Start()
	{
		highscore = PlayerPrefs.GetInt("HS", 0);
		if (Data.totalScore > highscore)
		{
			highscore = Data.totalScore;
			PlayerPrefs.SetInt("HS", highscore);

		}
		txHighScore.text = "Highscores: " + highscore;
	}

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
	}
}
