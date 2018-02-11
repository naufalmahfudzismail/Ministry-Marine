using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {



	public float starthealth = 1000;
	public float flashSpeed = 5f;
	public float currentHealth;
	public Color flashColor = new Color (1f, 0f, 0f, 0.1f);
	ControlBulletEnemy bullets;
	public Image damageImage;
	public Slider HealthBar;
	public GameObject bullet;

	bool isDamaged;

	// Use this for initialization
	void Awake () {

		currentHealth = starthealth;
		HealthBar.value = currentHealth;
		bullets = bullet.GetComponent<ControlBulletEnemy> ();

		
	}
	
	// Update is called once per frame
	void Update () {


		if (isDamaged) {

			damageImage.color = flashColor;
		} 

		else {

			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}

		isDamaged = false;

		if (currentHealth <= 0) {
			SceneManager.LoadScene ("GameOver");
		}
			
		
	}
		

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("EnemyBullet"))
		{
			Destroy (collision.gameObject);
			currentHealth -= bullets.Damage;
			HealthBar.value = currentHealth;
		}
	}

}
