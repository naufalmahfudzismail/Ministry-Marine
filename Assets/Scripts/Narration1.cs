using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Narration1 : MonoBehaviour {

	public Text Dubes;
	public Text Susi;
	public Text Narasi;
	public GameObject SusiTemplate;
	public GameObject DubesTemplate;
	string AnimasiText;
	public GameObject btnNext;
	public GameObject DubesAus;
	public GameObject DubesChina;
	public GameObject DubesPhili;
	public GameObject DubesMalay;
	public GameObject DubesVietnam;
	public GameObject DubesThai;
	public int counter;


	void Start()
	{
		Screen.SetResolution (1280, 800, true);
		Susi.text = "Susi";
		Narasi.text = "Kami dari pemerintahan Indonesia Menetapkan " +
			"Peraturan Undang Undang Nomor 32 tahun " +
			"2014 tentang kelautan yang berisikan : seluruh " +
			"daerah dari dasar laut hingga tanah nya yang berada di wilayah indonesia akan di lindungi dari praktek illegal fishing"; 
		
		AnimasiText = Narasi.text;
		Narasi.text = "";
		StartCoroutine ("PlayNarasi");
	}


	public void talk()
	{
		counter = counter + 1;
		btnNext.SetActive (false);

		if (counter == 2) {
			
			SusiTemplate.SetActive (false);
			DubesAus.SetActive (true);
			DubesTemplate.SetActive (true);
			Narasi.text = "Lalu hukuman apa yang Pemerintah Indonesia berikan jika kami melanggar undang undang tersebut?";
			Dubes.text = "dubes Australia";
		}

		if (counter == 3) {

			DubesTemplate.SetActive (false);
			DubesAus.SetActive (false);
			SusiTemplate.SetActive (true);
			Narasi.text = "Kami akan menangkap kapal kapal mereka, jika mereka kabur atau melawan maka kita akan tenggelamkan";
			Susi.text = "Menteri Susi";

		}

		if (counter == 4) {

			SusiTemplate.SetActive (false);
			DubesChina.SetActive (true);
			DubesTemplate.SetActive (true);
			Narasi.text = "Baiklah, saya akan berikan peringatan bagi para Nelayan di negara kami ";
			Dubes.text = "dubes Tiongkok";

		}

		if (counter == 5) {


			DubesChina.SetActive (false);
			DubesMalay.SetActive (true);
			Narasi.text = "Kami Mendukung apa yang telah pemerintah Indonesia tetapkan";
			Dubes.text = "dubes Malaysia";

		}

		if (counter == 6) {

			DubesTemplate.SetActive (false);
			DubesMalay.SetActive (false);
			SusiTemplate.SetActive (true);
			Narasi.text = "Baiklah, bagaimana dengan yang lain? apakah ada yang keberatan";
			Susi.text = "Menteri Susi";
		}

		if (counter == 7) {


			SusiTemplate.SetActive (false);
			DubesThai.SetActive (true);
			DubesTemplate.SetActive (true);
			Narasi.text = "Tidak ada, Kami menyetujui ";
			Dubes.text = "dubes Thailand";
		}

		if (counter == 8) {



			DubesThai.SetActive (false);
			DubesVietnam.SetActive (true);
			Narasi.text = "Kami pun juga menyetujui nya ";
			Dubes.text = "dubes Vietnam";

		}

		if (counter == 9) {

			DubesVietnam.SetActive (false);
			DubesPhili.SetActive (true);
			Narasi.text = "Tidak ada masalah, keadilan harus di tegakkan ";
			Dubes.text = "dubes Philipina";
		}


		if (counter == 10) {

			DubesTemplate.SetActive (false);
			DubesPhili.SetActive (false);
			SusiTemplate.SetActive (true);
			Narasi.text = "Dengan ini, kami akan melakukan tindakan kepada pelaku illegal fishing tanpa ada keberatan dari pihak yang terjangkit, hukum harus di tegakkan";
			Susi.text = "Menteri Susi";
			StartCoroutine (delay ());

		}

		if (counter == 11) {

			SceneManager.LoadScene ("Map");
		}
			


			AnimasiText = Narasi.text;
			Narasi.text = "";
			StartCoroutine ("PlayNarasi");
			
	
	}



	IEnumerator PlayNarasi()
	{
		
			foreach (char c in AnimasiText) {

				Narasi.text += c;
			yield return new WaitForSeconds (0.05f);
		} 
		btnNext.SetActive (true);
	}

	IEnumerator delay()
	{
		yield return new WaitForSeconds (3f);
	}
		
}
