using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMiniGames : MonoBehaviour {

	public float LimitMaxX;
	public float LimitMaxY;
	public float LimitMinX;
	public float LimitMinY;
	Transform t;

	// Use this for initialization
	void Awake () {

		t = transform;
	

	}

	// Update is called once per frame
	void Update () {

		if ((t.position.x >= LimitMaxX || t.position.x <= LimitMinX) || (t.position.y >= LimitMaxY || t.position.y <= LimitMinY)) {

			Destroy (gameObject);

		}



	}


	public void OnMouseDown()
	{
		Data.totalScore += 10;
		Destroy (gameObject);

	}
}
