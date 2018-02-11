using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySpawn : MonoBehaviour {

	public GameObject Ship;
	private Transform shipTransform;
	public float spawnTime;
	public int ShipCount;
	public float waveTime;
	public float userTime;
	public float shipMinSpeed;
	public float shipMaxSpeed;
	public Vector2 spawnValues;
	private int waveCount  = 0;
	private float shipSpeed;
	public int maxWaveCount;
	public Text score;
	public int Life;
	public static int Destroys;
	public Transform Minion;
	public float LimitMaxX;
	public float LimitMaxY;
	public float LimitMinX;
	public float LimitMinY;

	Rigidbody2D rb;


	// Use this for initialization
	void Start () {

		shipTransform = Ship.transform;
		rb = Ship.GetComponent<Rigidbody2D> ();
		StartCoroutine (spawnShip());	
	}
		
	IEnumerator spawnShip()
	{
		yield return new WaitForSeconds (userTime);
		while (true) {

			for (int i = 0; i < ShipCount; i++) {

				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);
				Quaternion spawnRotation = Quaternion.identity;

				for (float j = shipMinSpeed; j <= shipMaxSpeed; j++) {

					if (shipSpeed >= shipMaxSpeed) {

						shipSpeed = shipMaxSpeed;
					} 

					else 
					{
						shipSpeed = j + waveCount;
					}

				}
				Rigidbody2D bInstance= Instantiate(rb, spawnPosition, spawnRotation) as Rigidbody2D;
				bInstance.velocity = shipTransform.up * shipSpeed;
				yield return new WaitForSeconds (spawnTime);
			}
			waveCount++;
			yield return new WaitForSeconds (waveTime);
		}
			
	}
	
	// Update is called once per frame
	void Update () {

		score.text = "Total Score : " + Data.totalScore;
	}


	private void enemyDirection()
	{


		
		/*Rigidbody2D bInstance= Instantiate(rb, shipTransform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as Rigidbody2D;
		bInstance.velocity = shipTransform.up * shipSpeed;*/
	}


}
