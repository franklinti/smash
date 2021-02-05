using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;

	public bool youlose,youwin;
	public bool startGame;

	public GameObject[] barata;

//	public Transform  posYWall2,posYSpriteWall2, posYWall1, posYSpriteWall1;
	void Awake(){
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
		startGame = true;
		youwin = false;
		//executa for para carregar baratas em cena
		for (int i = 0; i < barata.Length; i++) {
			Instantiate (barata[i]);
		}
		//UIManager.instance.StartUI ();
	}
	void Update(){
		//UIManager.instance.UpdateUI ();
	}














	public void BarataWall1(){
		//posYWall1 = GameObject.Find ("wall1").GetComponent<Transform> ().transform;
		//posYSpriteWall1 = GameObject.Find ("posYSpriteWall1").GetComponent<Transform> ().transform;
		//posYSpriteWall1.transform.position = new Vector3 (0, posYWall1.transform.position.y, 0);
	}
}
