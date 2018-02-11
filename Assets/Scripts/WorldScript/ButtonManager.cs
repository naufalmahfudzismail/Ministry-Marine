using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Screen.SetResolution (1280, 800, true);

	}

	// Update is called once per frame
	void Update () {

	}

	public void Mulai() {
		SceneManager.LoadScene("Narration");
	}
	public void Set() {
		SceneManager.LoadScene("Setting");
	}

	public void Map()
	{
		SceneManager.LoadScene("Map");
	}

	public void stage1()
	{
		SceneManager.LoadScene("Stage1-1");
	}

	public void stage2()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage1 = true;
	}
	public void stage3()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage2 = true;
	}
	public void stage4()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage3 = true;
	}
	public void stage5()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage4 = true;
	}
	public void stage6()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage5 = true;
	}
	public void stage7()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage6 = true;
	}
	public void stage8()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage7 = true;
	}

	public void stage9()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage8 = true;
	}

	public void stage10()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage9 = true;
	}

	public void stage11()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage10 = true;
	}

	public void stage12()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage11 = true;
	}

	public void stage13()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage12 = true;
	}
	public void stage14()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage13 = true;
	}

	public void stage15()
	{
		SceneManager.LoadScene("Map");
		LevelManager.stage14 = true;
	}

	public void Pause()
	{
		
	}


	public void home()
	{
		SceneManager.LoadScene("Menu");
		Data.totalScore = 0;
		Data.totalShip = 0;
		TargetShip.EscapeShip = 0;
		LevelManager.stage1 = false;
		LevelManager.stage2 = false;
		LevelManager.stage3 = false;
		LevelManager.stage4 = false;
		LevelManager.stage5 = false;
		LevelManager.stage6 = false;
		LevelManager.stage7 = false;
		LevelManager.stage8 = false;
		LevelManager.stage9 = false;
		LevelManager.stage10 = false;
		LevelManager.stage11 = false;
		LevelManager.stage12 = false;
		LevelManager.stage13 = false;
		LevelManager.stage14 = false;


	}

	public void nextlevel()
	{
		if 
			(
				!LevelManager.stage1 && !LevelManager.stage2 && !LevelManager.stage3  && !LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");
			LevelManager.IsStage1 = true;
		} 
		else if 
			(
				LevelManager.stage1 && !LevelManager.stage2 && !LevelManager.stage3  && !LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-2");
			LevelManager.IsStage2 = true;
			LevelManager.IsStage1 = false;
			//Data.totalScore = LevelManager.scoreStage1;
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && !LevelManager.stage3  && !LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-3");	
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = true;
			//Data.totalScore= LevelManager.scoreStage1 + LevelManager.scoreStage2;

		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && !LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");
			LevelManager.IsStage4 = true;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;
			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3;
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");	
			LevelManager.IsStage5 = true;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;
			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4;

		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");	
			LevelManager.IsStage6 = true;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;
			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage5;

		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && !LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");
			LevelManager.IsStage7 = true;
			LevelManager.IsStage6 = false;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;
			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage6;
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");	
			LevelManager.IsStage8 = true;
			LevelManager.IsStage7 = false;
			LevelManager.IsStage6 = false;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;

			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage6 + LevelManager.scoreStage7;
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");	
			LevelManager.IsStage9 = true;
			LevelManager.IsStage8 = false;
			LevelManager.IsStage7 = false;
			LevelManager.IsStage6 = false;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;

			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage6 + LevelManager.scoreStage7 + LevelManager.scoreStage8;
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");	
			LevelManager.IsStage10 = true;
			LevelManager.IsStage9 = false;
			LevelManager.IsStage8 = false;
			LevelManager.IsStage7 = false;
			LevelManager.IsStage6 = false;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;

			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage6 + LevelManager.scoreStage7 + LevelManager.scoreStage8 + LevelManager.scoreStage9;
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");	
			LevelManager.IsStage11 = true;
			LevelManager.IsStage10 = false;
			LevelManager.IsStage9 = false;
			LevelManager.IsStage8 = false;
			LevelManager.IsStage7 = false;
			LevelManager.IsStage6 = false;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;

			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage6 + LevelManager.scoreStage7 + LevelManager.scoreStage8 + LevelManager.scoreStage9
			//+ LevelManager.scoreStage10;
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");	
			LevelManager.IsStage12 = true;
			LevelManager.IsStage11 = false;
			LevelManager.IsStage10 = false;
			LevelManager.IsStage9 = false;
			LevelManager.IsStage8 = false;
			LevelManager.IsStage7 = false;
			LevelManager.IsStage6 = false;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;
			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage6 + LevelManager.scoreStage7 + LevelManager.scoreStage8 + LevelManager.scoreStage9
			//+ LevelManager.scoreStage10 + LevelManager.scoreStage11;
		}  	

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && LevelManager.stage11  && LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");	
			LevelManager.IsStage13 = true;
			LevelManager.IsStage12 = false;
			LevelManager.IsStage11 = false;
			LevelManager.IsStage10 = false;
			LevelManager.IsStage9 = false;
			LevelManager.IsStage8 = false;
			LevelManager.IsStage7 = false;
			LevelManager.IsStage6 = false;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;

			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage6 + LevelManager.scoreStage7 + LevelManager.scoreStage8 + LevelManager.scoreStage9
			//+ LevelManager.scoreStage10 + LevelManager.scoreStage11 + LevelManager.scoreStage12;
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && LevelManager.stage11  && LevelManager.stage12
				&& LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");
			LevelManager.IsStage14 = true;
			LevelManager.IsStage13 = false;
			LevelManager.IsStage12 = false;
			LevelManager.IsStage11 = false;
			LevelManager.IsStage10 = false;
			LevelManager.IsStage9 = false;
			LevelManager.IsStage8 = false;
			LevelManager.IsStage7 = false;
			LevelManager.IsStage6 = false;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;

			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage6 + LevelManager.scoreStage7 + LevelManager.scoreStage8 + LevelManager.scoreStage9
			//+ LevelManager.scoreStage10 + LevelManager.scoreStage11 + LevelManager.scoreStage12 + LevelManager.scoreStage13;
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && LevelManager.stage11  && LevelManager.stage12
				&& LevelManager.stage13  && LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			SceneManager.LoadScene ("Stage1-1");

			LevelManager.IsStage15 = true;
			LevelManager.IsStage14 = false;
			LevelManager.IsStage13 = false;
			LevelManager.IsStage12 = false;
			LevelManager.IsStage11 = false;
			LevelManager.IsStage10 = false;
			LevelManager.IsStage9 = false;
			LevelManager.IsStage8 = false;
			LevelManager.IsStage7 = false;
			LevelManager.IsStage6 = false;
			LevelManager.IsStage5 = false;
			LevelManager.IsStage4 = false;
			LevelManager.IsStage2 = false;
			LevelManager.IsStage1 = false;
			LevelManager.IsStage3 = false;
			//Data.totalScore = LevelManager.scoreStage1 + LevelManager.scoreStage2 + LevelManager.scoreStage3 + LevelManager.scoreStage4 + LevelManager.scoreStage6 + LevelManager.scoreStage7 + LevelManager.scoreStage8 + LevelManager.scoreStage9
			//+ LevelManager.scoreStage10 + LevelManager.scoreStage11 + LevelManager.scoreStage12 + LevelManager.scoreStage13 + LevelManager.scoreStage14;
		} 
	}

	public void Continue()

	{
		
	}
		

	public void Reset()
	{


	}
	public void Exit() {
		Application.Quit();
	}
}