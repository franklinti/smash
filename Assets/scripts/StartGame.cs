using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class StartGame : MonoBehaviour {


	bool play;
	public float tempo;

	//public Image imgplay;
	//public float speedcorimg = 5;
	//public Color cor = new Color (1f,0,0f,0.1f);

	// Use this for initialization
	void Start () {
		tempo = 60f;

	//	imgplay = GameObject.Find ("Play").GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		//ContaTempo ();
        if (play)
        {
            SceneManager.LoadScene("Menu");
        }
		//imgplay = GameObject.Find ("Play").GetComponent<Image> ();
		//imgplay.color = Color.Lerp (imgplay.color, Color.yellow, speedcorimg * Time.deltaTime);

	}
	public void Play(bool valor){
		play = valor;
	}
	void ContaTempo(){
		if (tempo > 0) {
			tempo = tempo * Time.deltaTime;
			if(tempo <= 0){
				
				SceneManager.LoadScene("Menu");

			}
		}
	}
}
