using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class YouWin : MonoBehaviour
{
	public static YouWin instance;
	//painel youwin
	GameObject youwinUI,starsUI1,starsUI2,starsUI3;
	public GameObject star1UI,star2UI,star3UI;
	public float tempo;
	Button btnreload;

	void Awake(){
		if (instance == null) {
			instance = this;
		//	DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
	void Start(){
		youwinUI = GameObject.Find ("YouWin") as GameObject;
		youwinUI.SetActive (false);
		tempo = 2.0f;
	}
	public void Win(){
		youwinUI.SetActive (true);
		btnreload = GameObject.Find ("BtnReload").GetComponent<Button> ();
		btnreload.GetComponent <Button>().interactable = false;
		youwinUI.GetComponent<Animator> ().Play ("Pause");
		Destroy (GameObject.Find ("BarataWall1(Clone)"));
		Destroy (GameObject.Find ("BarataWall2(Clone)"));
		tempo -= Time.deltaTime;
		if (tempo <= 0 && PontoManager.instance.qtdBaratas == 1) {
			Star1 ();
			tempo = 0;
		}
		if (tempo <= 0 && PontoManager.instance.qtdBaratas == 2) {
			Star2 ();
			tempo = 0;
		}
		if (tempo <= 0 && PontoManager.instance.qtdBaratas == 3) {
			Star3 ();
			tempo = 0;
		}

	}
	void Star1(){
		starsUI1 = GameObject.Find ("Star1") as GameObject; 
		//starsUI.GetComponent<Animator> ().Play ("Star");
		starsUI1.GetComponent<Image> ().enabled = true;
		Destroy (GameObject.Find ("GameManager(Clone)"));
		StartCoroutine ( EnabledBtnReload());
	}
	void Star2(){
		starsUI1 = GameObject.Find ("Star1") as GameObject; 
		starsUI2 = GameObject.Find ("Star2") as GameObject; 
		starsUI1.GetComponent<Image> ().enabled = true;
		starsUI2.GetComponent<Image> ().enabled = true;
		Destroy (GameObject.Find ("GameManager(Clone)"));
		StartCoroutine ( EnabledBtnReload());
	}
	void Star3(){
		starsUI1 = GameObject.Find ("Star1") as GameObject; 
		starsUI2 = GameObject.Find ("Star2") as GameObject; 
		starsUI3 = GameObject.Find ("Star3") as GameObject; 
		starsUI1.GetComponent<Image> ().enabled = true;
		starsUI2.GetComponent<Image> ().enabled = true;
		starsUI3.GetComponent<Image> ().enabled = true;
		Destroy (GameObject.Find ("GameManager(Clone)"));
		StartCoroutine ( EnabledBtnReload());
	}
	IEnumerator EnabledBtnReload(){
		yield return new WaitForSeconds (1f);
		btnreload.GetComponent <Button>().interactable = true;
		Destroy (GameObject.Find ("PontoManager"));
	} 
}
