using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public bool isMinion = false;
	public bool isFighter = false;
	public Transform Player;
	public Transform Escape;
	public Transform border;
	public Rigidbody2D shot;
	public Transform shotSpawn;
	public Vector2 maxXAndY;		// The maximum x and y coordinates the camera can have.
	public Vector2 minXAndY;		// The minimum x and y coordinates the camera can have.
	public float range;
	public float FireRateFighter;
	public float bulletSpeedFighter;
	public float speed;
	private float nextFire;
	private float distance;
	private bool isCiduk;
	private float step;
	private Transform obstacle;
	private float rangeObstacle = 2;
	bool isCatched;
	bool kena;

	// Use this for initialization
	void Awake() {

		obstacle = GameObject.FindGameObjectWithTag("Obstacle").transform;
	

	}
	
	// Update is called once per frame
	void Update () {

		if (!isCatched) {
		

			if (isMinion && !isFighter) {

				Minion ();

				transform.localEulerAngles = new Vector2 (0, 0);


			} else if (isFighter && !isMinion) {

				fighter ();
			}


			LimitEnemy ();
		}
			


	


	}

	protected void LateUpdate()
	{
		

	}
		

	private void Minion()
	{

		distance = Vector2.Distance (obstacle.position, transform.position);
		step = speed * Time.deltaTime;

		if (distance > rangeObstacle) {

			transform.LookAt (Player);
			distance = Vector2.Distance (Player.position, transform.position);
			step = speed * Time.deltaTime;
		
			if (distance < range) {
			
				isCiduk = true;
			}

			if (isCiduk) {


				transform.position = Vector3.MoveTowards (transform.position, Escape.position, step);

			
				avoidObstacle ();
			}

		} 
		else
		{
			Vector2 moveDir = -1 * (obstacle.transform.position - transform.position);
			transform.Translate (moveDir.normalized * step);

		}

			
	}

	private void fighter()
	{
		step = speed * Time.deltaTime;
		distance = Vector2.Distance (Player.position, transform.position);
		if (distance < range) 
		{
			//transform.LookAt(new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z),transform.up);
			// moving towards to player
			/*Vector3 look = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z) - transform.position;
			Quaternion rotation = Quaternion.LookRotation(-look, Vector3.up);
			transform.rotation = Quaternion.Slerp ( transform.rotation, rotation, Time.deltaTime * 2.0f);*/

			Vector2 direction = Player.position - transform.position;
			float angle = Mathf.Atan2 (direction.y, direction.x) * Mathf.Rad2Deg - 90f;
			Quaternion rotation = Quaternion.AngleAxis (angle, Vector3.forward);
			transform.rotation = Quaternion.Slerp ( transform.rotation, rotation, Time.deltaTime * 5f);


			if (Time.time > nextFire) {
				nextFire = Time.time + FireRateFighter;
				Rigidbody2D bInstance = Instantiate (shot, shotSpawn.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Rigidbody2D;
				bInstance.velocity = transform.up * bulletSpeedFighter;
				}

			}
}

	
			

		
	private void avoidObstacle()
	{
		distance = Vector2.Distance (obstacle.position, transform.position);
		step = speed * Time.deltaTime;
		if (distance < rangeObstacle) {

			Vector2 moveDir = obstacle.transform.position - transform.position;
			transform.Translate (moveDir.normalized * step);

		} 
			
						
	}

	private void LimitEnemy()
	{
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
		targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

		transform.position = new Vector3(targetX, targetY, transform.position.z);
	}


	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("Bullet"))
		{
			isCatched = true;
			Destroy (collision.gameObject);
			Destroy (gameObject);
			Data.totalScore += 25;
			Data.totalShip += 1;

		}


	}


		
		
}
