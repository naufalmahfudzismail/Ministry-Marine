using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetShip : MonoBehaviour {

	public int TargetCountShip;
	public int TargetEscape;
	public static int EscapeShip;

	// Use this for initialization
	void Start () {
		Screen.SetResolution (1280, 800, true);
	}
	
	// Update is called once per frame
	void Update () {

		if (Data.totalShip >= TargetCountShip) {


			if (LevelManager.IsStage1) {
				
				LevelManager.stage1 = true;
				LevelManager.IsStage2 = true;
				LevelManager.IsStage1 = false;
				SceneManager.LoadScene ("Map");
				
			}
			else if (LevelManager.IsStage2)
			{
				LevelManager.stage2= true;
				LevelManager.IsStage3 = true;
				LevelManager.IsStage2 = false;
				LevelManager.IsStage1 = false;
				SceneManager.LoadScene ("Map");
			}
			else if (LevelManager.IsStage3)
			{
				LevelManager.stage3 = true;
				LevelManager.IsStage4= true;
				LevelManager.IsStage3 = false;
				LevelManager.IsStage2 = false;
				LevelManager.IsStage1 = false;
				SceneManager.LoadScene ("MiniGames1");

			}
			else if (LevelManager.IsStage4)
			{
				
				LevelManager.stage4 = true;
				LevelManager.IsStage5 = true;
				LevelManager.IsStage4 = false;
				LevelManager.IsStage3 = false;
				LevelManager.IsStage2 = false;
				LevelManager.IsStage1 = false;

			}
			else if (LevelManager.IsStage5)
			{
				
				LevelManager.stage5 = true;
				LevelManager.IsStage6 = true;
				LevelManager.IsStage5 = false;
				LevelManager.IsStage4 = false;
				LevelManager.IsStage3 = false;
				LevelManager.IsStage2 = false;
				LevelManager.IsStage1 = false;
			}
			else if (LevelManager.IsStage6)
			{
				
				LevelManager.IsStage7 = true;
				LevelManager.IsStage6 = true;
				LevelManager.IsStage5 = false;
				LevelManager.IsStage4 = false;
				LevelManager.IsStage3 = false;
				LevelManager.IsStage2 = false;
				LevelManager.IsStage1 = false;
			}
			else if (LevelManager.IsStage7)
			{
				
				LevelManager.stage7 = true;
				LevelManager.IsStage8 = true;
				LevelManager.IsStage7 = false;
				LevelManager.IsStage6 = false;
				LevelManager.IsStage5 = false;
				LevelManager.IsStage4 = false;
				LevelManager.IsStage3 = false;
				LevelManager.IsStage2 = false;
				LevelManager.IsStage1 = false;
			}
			else if (LevelManager.IsStage8)
			{
				LevelManager.stage8 = true;
			
			}
			else if (LevelManager.IsStage9)
			{
				LevelManager.stage9 = true;

			}
			else if (LevelManager.IsStage10)
			{
				LevelManager.stage10 = true;

			}
			else if (LevelManager.IsStage11)
			{
				LevelManager.stage11 = true;

			}
			else if (LevelManager.IsStage12)
			{
				LevelManager.stage12 = true;
			}
			else if (LevelManager.IsStage13)
			{
				
				LevelManager.stage13 = true;
			}
			else if (LevelManager.IsStage14)
			{
				LevelManager.stage14 = true;

			}
			else if (LevelManager.IsStage15)
			{
				LevelManager.stage15 = true;
			}



		}


		if (TargetEscape == EscapeShip) {
			SceneManager.LoadScene ("GameOver");
		}
		
	}



}
