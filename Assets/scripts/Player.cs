using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
	public static Player instance;

	public int life;
	public GameObject[] imglife;
	public bool colisao;
	public bool die;
    // Start is called before the first frame update
    void Start()
    {
		life = 1;
		imglife = GameObject.FindGameObjectsWithTag ("life");
	    for (int i = 0; i < imglife.Length; i++) {
			imglife[i].GetComponent<Image> ().enabled = true;
		}
    }
	void Update(){
		if (die) {
			switch (PontoManager.instance.qtdBaratas) {
			case 0:
				YouLose.instance.Lose ();
				break;
			case 1:
				YouLose.instance.Lose ();
				break;
			}
		}
	}
	public void PerdeLife(int perdeLife){
		
		if (life >= 0 ) {
			life -= perdeLife;
			GameObject img = GameObject.FindWithTag ("life");
			img.SetActive (false);
		} else {
			die = true;
		}
	}
	public void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.CompareTag ("enemy")) {
			colisao = true; 
			PerdeLife (1);
		}
	}



    
}
