using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
	
public class ControlBehaviour : MonoBehaviour {

	float directionX;
	float directionY;
	public float speed = 10f;
	public float fireRate;
	public float bulletSpeed = 20f;
	private float nextFire;
	public Rigidbody2D shot;
	public Transform shotSpawn;
	public Vector2 maxXAndY;		// The maximum x and y coordinates the camera can have.
	public Vector2 minXAndY;		// The minimum x and y coordinates the camera can have.
	Rigidbody2D rb;
	bool isBoost;
	// Use this for initialization
	void Awake () {

		rb = GetComponent<Rigidbody2D>();

	
	}

	// Update is called once per frame

	void FixedUpdate ()
	{

		Vector3 move = new Vector3 (CrossPlatformInputManager.GetAxis ("Horizontal"),
			               CrossPlatformInputManager.GetAxis ("Vertical"), 2048);

		if (move.x != 0 && move.y != 0) {
			transform.rotation = Quaternion.LookRotation (move, Vector3.back);
		}

		LimitPlayer ();

		rb.velocity = move * speed;


		
	}





	/*protected void LateUpdate()
	{
		//transform.localEulerAngles = new Vector2 (0, 0);
	}*/

	public void fire()


	{

		if (Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Rigidbody2D bInstance = Instantiate (shot, shotSpawn.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Rigidbody2D;
			bInstance.velocity = transform.up * bulletSpeed;
		}

	}

	private void LimitPlayer()
	{
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
		targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

		transform.position = new Vector2(targetX, targetY);
	}
		





}
