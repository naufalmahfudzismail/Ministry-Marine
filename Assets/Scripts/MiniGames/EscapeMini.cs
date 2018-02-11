using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EscapeMini : MonoBehaviour {

	public Text Lifes;
	public int Life;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Life <= 0) {

			SceneManager.LoadScene ("Finish");
		}

		Lifes.text = "Life : " + Life;
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag.Equals("Enemy"))
		{
			Destroy (collision.gameObject);
			Life--;

		}
	}
}
