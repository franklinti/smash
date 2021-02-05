using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PontoManager : MonoBehaviour {

	public static PontoManager instance;

	public int pontos = 0;
	public int qtdBaratas = 0;
    public Text txtPonto,txtBarata;


	void Awake(){
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		txtPonto = GameObject.Find("TxtScore").GetComponent<Text> ();
		txtBarata = GameObject.Find("TxtBarata").GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		txtPonto.text = "Score: " + pontos.ToString();
		txtBarata.text = "" + qtdBaratas.ToString ();
		if (SceneManager.GetActiveScene ().name == "Level" && qtdBaratas == 2) {
			YouWin.instance.Win ();
		} 
	}
}
