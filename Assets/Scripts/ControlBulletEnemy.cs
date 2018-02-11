using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBulletEnemy : MonoBehaviour {

	public float LimitMaxX;
	public float LimitMaxY;
	public float LimitMinX;
	public float LimitMinY;
	public float BorderXMax = 8;
	public float BorderXMin = -8;
	public float BorderYMax = 6;
	public float BorderYMin = -6;
	public float Damage;
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


		
}
