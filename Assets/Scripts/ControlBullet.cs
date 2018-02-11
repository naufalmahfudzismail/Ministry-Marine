using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBullet : MonoBehaviour {

	//Remove Object, If through the map

	public float LimitMaxX;
	public float LimitMaxY;
	public float LimitMinX;
	public float LimitMinY;
	public float BorderXMax = 8;
	public float BorderXMin = -8;
	public float BorderYMax = 6;
	public float BorderYMin = -6;
	private bool isVisible;
	private Transform border;
	private float xMax;
	private float xMin;
	private float yMax;
	private float yMin;
	Transform t;

	// Use this for initialization

	void Awake () {
		

		t = transform;
		border = GameObject.FindGameObjectWithTag ("MainCamera").transform;
		xMax = border.position.x + BorderXMax;
		xMin = border.position.x + BorderXMin;
		yMax = border.position.y + BorderYMax;
		yMin = border.position.y + BorderYMin;


	}
	
	// Update is called once per frame
	void Update () {

		if (
			((t.position.x >= LimitMaxX || t.position.x <= LimitMinX) || (t.position.y >= LimitMaxY || t.position.y <= LimitMinY)) 

			||

			(( t.position.x >= xMax || t.position.x <= xMin) || (t.position.y >= yMax || t.position.y <= yMin))
			)

		{
			
			Destroy (gameObject);
		}
			
	}
		

	 /*void OnCollisionEnter2D(Collision2D collision)

	{
		if(collision.gameObject.tag.Equals("Enemy"))
		{


			kena = true;
			Destroy (gameObject);


		}

		if (collision.gameObject.tag.Equals ("EnemyBullet")) {

			Destroy (gameObject);
		}


	}






	private void getScore()
	{
		if (LevelManager.IsStage1) {
			LevelManager.scoreStage1 += 25;
			Data.score += LevelManager.scoreStage1;
		}
		else if (LevelManager.IsStage2)
		{
			LevelManager.scoreStage2 += 25;
			Data.score += LevelManager.scoreStage2;
		}
		else if (LevelManager.IsStage3)
		{
			LevelManager.scoreStage3 += 25;
			Data.score += LevelManager.scoreStage3;
		}
		else if (LevelManager.IsStage4)
		{
			LevelManager.scoreStage4 += 25;
			Data.score += LevelManager.scoreStage4;
		}
		else if (LevelManager.IsStage5)
		{
			LevelManager.scoreStage5 += 25;
			Data.score += LevelManager.scoreStage5;
		}
		else if (LevelManager.IsStage6)
		{
			LevelManager.scoreStage6 += 25;
			Data.score += LevelManager.scoreStage6;
		}
		else if (LevelManager.IsStage7)
		{
			LevelManager.scoreStage7 += 25;
			Data.score += LevelManager.scoreStage7;
		}
		else if (LevelManager.IsStage8)
		{
			LevelManager.scoreStage8 += 25;
			Data.score += LevelManager.scoreStage8;
		}
		else if (LevelManager.IsStage9)
		{
			LevelManager.scoreStage9 += 25;
			Data.score += LevelManager.scoreStage9;
		}
		else if (LevelManager.IsStage10)
		{
			LevelManager.scoreStage10 += 25;
			Data.score += LevelManager.scoreStage10;
		}
		else if (LevelManager.IsStage11)
		{
			LevelManager.scoreStage11 += 25;
			Data.score += LevelManager.scoreStage11;
		}
		else if (LevelManager.IsStage12)
		{
			LevelManager.scoreStage12 += 25;
			Data.score += LevelManager.scoreStage12;
		}
		else if (LevelManager.IsStage13)
		{
			LevelManager.scoreStage13 += 25;
			Data.score += LevelManager.scoreStage13;
		}
		else if (LevelManager.IsStage14)
		{
			LevelManager.scoreStage14 += 25;
			Data.score += LevelManager.scoreStage14;
		}
		else if (LevelManager.IsStage15)
		{
			LevelManager.scoreStage15 += 25;
			Data.score += LevelManager.scoreStage15;
		}
		
	}*/

		
}
