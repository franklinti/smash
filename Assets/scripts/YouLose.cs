using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class YouLose : MonoBehaviour
{
	public static YouLose instance;

	//painel youlose/
	GameObject youloseUI,starsUI;
	public GameObject starUI1,starUI2,starUI3;
	public float tempo;
	Button btnreload;

	void Awake(){
		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
		youloseUI = GameObject.Find ("YouLose") as GameObject;
		youloseUI.SetActive (false);
		tempo = 2.0f;  
    }
	public void Lose(){
		youloseUI.SetActive (true);
		btnreload = GameObject.Find ("BtnReload").GetComponent<Button> ();
		btnreload.GetComponent <Button>().interactable = false;
		youloseUI.GetComponent<Animator> ().Play ("Pause");
		tempo -= Time.deltaTime;
		if (tempo <= 0) {
			Star ();
			tempo = 0;
		}
		Destroy (GameObject.Find ("BarataWall1(Clone)"));
		Destroy (GameObject.Find ("BarataWall2(Clone)"));
	}
	public void Star(){
		starsUI = GameObject.Find ("Stars") as GameObject;
		starsUI.GetComponent<Animator> ().Play ("Star");
		Destroy (GameObject.Find ("GameManager(Clone)"));
		Destroy (GameObject.Find ("PontoManager"));
	}
}
