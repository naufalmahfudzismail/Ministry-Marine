using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextManager : MonoBehaviour {

	public Text TextScore;
	public Text TextLevel;
	public Text ShipCounts;




	// Use this for initialization
	void Start () {

		Screen.SetResolution (1280, 800, true);

		
	}
		
	
	// Update is called once per frame
	void Update () {

		if (LevelManager.IsStage1) {
			TextLevel.text = "level 1 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage1;
		}
		else if (LevelManager.IsStage2)
		{
			TextLevel.text = "level 1 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage2;
		}
		else if (LevelManager.IsStage3)
		{
			TextLevel.text = "level 1 - 3";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage3;
		}
		else if (LevelManager.IsStage4)
		{
			TextLevel.text = "level 2 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage4;

		}
		else if (LevelManager.IsStage5)
		{
			TextLevel.text = "level 2 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage5;

		}
		else if (LevelManager.IsStage6)
		{
			TextLevel.text = "level 2 - 3 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage6;

		}
		else if (LevelManager.IsStage7)
		{
			TextLevel.text = "level 3 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage7;

		}
		else if (LevelManager.IsStage8)
		{
			TextLevel.text = "level 3 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage8;

		}
		else if (LevelManager.IsStage9)
		{
			TextLevel.text = "level 3 - 3 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage9;

		}
		else if (LevelManager.IsStage10)
		{
			TextLevel.text = "level 4 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage10;

		}
		else if (LevelManager.IsStage11)
		{
			TextLevel.text = "level 4 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage11;

		}
		else if (LevelManager.IsStage12)
		{
			TextLevel.text = "level 4 - 3 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage12;

		}
		else if (LevelManager.IsStage13)
		{
			TextLevel.text = "level 5 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage13;

		}
		else if (LevelManager.IsStage14)
		{
			TextLevel.text = "level 5 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage14;

		}
		else if (LevelManager.IsStage15)
		{
			TextLevel.text = "Final Battle";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage15;

		}



		TextScore.text = "Score : " + Data.totalScore;
		ShipCounts.text = "Kapal tertangkap : " + Data.totalShip;


		
	}
}
