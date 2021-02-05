using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveInimigo : MonoBehaviour {


	float alturaDoSprite;
	float posicaoAcima;
	float larguraTela;

//	public static bool contReposicionar;
	public GameObject explosao;



	// Use this for initialization
	void Start () {
		alturaDoSprite = GetComponent<SpriteRenderer>().bounds.size.y;
		posicaoAcima = Camera.main.orthographicSize + alturaDoSprite;
		transform.position = new Vector3(2, posicaoAcima, -2);

		float taxaHorizontal = (float)Screen.width / (float)Screen.height;
		larguraTela = Camera.main.orthographicSize * taxaHorizontal;


	}

	// Update is called once per frame
	void Update () {


		if(transform.position.y + alturaDoSprite < -Camera.main.orthographicSize)
		{
			reposicionar();
			//contReposicionar = true;
		}
	}
	void reposicionar()
	{
		float x = Random.Range(-larguraTela, larguraTela);
		transform.position = new Vector3(x, posicaoAcima, -2);

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{

		if(collision.tag == "Player")
		{
			VidaManager.vidas -= 1;

		}
		switch(VidaManager.vidas){
		case 0:
			SceneManager.LoadScene ("GameOver");
			break;
		}
		if(collision.tag == "bullet")
		{
			GameObject obj = Instantiate(explosao);
			obj.transform.position = transform.position;
			//PontoManager.pontos += 1;
		}
		/*
		switch(PontoManager.pontos){
		//Ganha uma vida com sem asteroides destruidos
		case 100:
			VidaManager.vidas += 1;
			SceneManager.LoadScene ("Stage01");
			break;
		}

		reposicionar();
		*/
	}
}
