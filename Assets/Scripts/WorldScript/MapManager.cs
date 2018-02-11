using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour {

	public GameObject level1;
	public GameObject level2;
	public GameObject level3;
	public GameObject level4;
	public GameObject level5;
	public GameObject level6;
	public GameObject level7;
	public GameObject level8;
	public GameObject level9;
	public GameObject level10;
	public GameObject level11;
	public GameObject level12;
	public GameObject level13;
	public GameObject level14;
	public GameObject level15;
	public GameObject BtnNext;

	public Text TextScore;
	public Text TextLevel;
	public Text ShipCounts;

	// Use this for initialization
	void Start () {
		Screen.SetResolution (1280, 800, true);
	}
	
	// Update is called once per frame
	void Update () {

		textLevel ();
		OnObject ();
		StartCoroutine (ButtonView ());
	}


	IEnumerator ButtonView()
	{
		yield return new WaitForSeconds (5f);
		BtnNext.SetActive (true);

	}

	private void OnObject()
	{
		if 
			(
				!LevelManager.stage1 && !LevelManager.stage2 && !LevelManager.stage3  && !LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
		} 
		else if 
			(
				LevelManager.stage1 && !LevelManager.stage2 && !LevelManager.stage3  && !LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && !LevelManager.stage3  && !LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && !LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& !LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);	
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && !LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);	
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && !LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && !LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);
			level7.SetActive (true);
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && !LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);
			level7.SetActive (true);
			level8.SetActive (true);	
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& !LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);
			level7.SetActive (true);
			level8.SetActive (true);
			level9.SetActive (true);
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && !LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);
			level7.SetActive (true);
			level8.SetActive (true);
			level9.SetActive (true);
			level10.SetActive (true);
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && !LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);
			level7.SetActive (true);
			level8.SetActive (true);
			level9.SetActive (true);
			level10.SetActive (true);
			level11.SetActive (true);
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && LevelManager.stage11  && !LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);
			level7.SetActive (true);
			level8.SetActive (true);
			level9.SetActive (true);
			level10.SetActive (true);
			level11.SetActive (true);
			level12.SetActive (true);	
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && LevelManager.stage11  && LevelManager.stage12
				&& !LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);
			level7.SetActive (true);
			level8.SetActive (true);
			level9.SetActive (true);
			level10.SetActive (true);
			level11.SetActive (true);
			level12.SetActive (true);
			level13.SetActive (true);
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && LevelManager.stage11  && LevelManager.stage12
				&& LevelManager.stage13  && !LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);
			level7.SetActive (true);
			level8.SetActive (true);
			level9.SetActive (true);
			level10.SetActive (true);
			level11.SetActive (true);
			level12.SetActive (true);
			level13.SetActive (true);
			level14.SetActive (true);	
		} 

		else if 
			(
				LevelManager.stage1 && LevelManager.stage2 && LevelManager.stage3  && LevelManager.stage4
				&& LevelManager.stage5  && LevelManager.stage6  && LevelManager.stage7  && LevelManager.stage8
				&& LevelManager.stage9  && LevelManager.stage10  && LevelManager.stage11  && LevelManager.stage12
				&& LevelManager.stage13  && LevelManager.stage14  && !LevelManager.stage15
			) 
		{
			level1.SetActive (true);
			level2.SetActive (true);
			level3.SetActive (true);
			level4.SetActive (true);
			level5.SetActive (true);
			level6.SetActive (true);
			level7.SetActive (true);
			level8.SetActive (true);
			level9.SetActive (true);
			level10.SetActive (true);
			level11.SetActive (true);
			level12.SetActive (true);
			level13.SetActive (true);
			level14.SetActive (true);
			level15.SetActive (true);	
		} 
	}

	private void textLevel()
	{
		if (LevelManager.IsStage1) {
			TextLevel.text = "1 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage1;
		}
		else if (LevelManager.IsStage2)
		{
			TextLevel.text = "1 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage2;
		}
		else if (LevelManager.IsStage3)
		{
			TextLevel.text = "1 - 3";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage3;
		}
		else if (LevelManager.IsStage4)
		{
			TextLevel.text = "2 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage4;

		}
		else if (LevelManager.IsStage5)
		{
			TextLevel.text = "2 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage5;

		}
		else if (LevelManager.IsStage6)
		{
			TextLevel.text = "2 - 3 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage6;

		}
		else if (LevelManager.IsStage7)
		{
			TextLevel.text = "3 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage7;

		}
		else if (LevelManager.IsStage8)
		{
			TextLevel.text = "3 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage8;

		}
		else if (LevelManager.IsStage9)
		{
			TextLevel.text = "3 - 3 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage9;

		}
		else if (LevelManager.IsStage10)
		{
			TextLevel.text = "4 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage10;

		}
		else if (LevelManager.IsStage11)
		{
			TextLevel.text = "4 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage11;

		}
		else if (LevelManager.IsStage12)
		{
			TextLevel.text = "4 - 3 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage12;

		}
		else if (LevelManager.IsStage13)
		{
			TextLevel.text = "5 - 1 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage13;

		}
		else if (LevelManager.IsStage14)
		{
			TextLevel.text = "5 - 2 ";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage14;

		}
		else if (LevelManager.IsStage15)
		{
			TextLevel.text = "Final Battle";
			//TextScore.text = "Score : " + Data.totalScore + LevelManager.scoreStage15;

		}


		TextScore.text = "" + Data.totalScore;
		ShipCounts.text = "" + Data.totalShip;


	}
}
