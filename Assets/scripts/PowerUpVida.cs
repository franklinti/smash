using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpVida : MonoBehaviour {
	public float veloc = 5f;
	float alturaDoSprite;
	float posicaoAcima;
	float larguraTela;

	private int contPowerUpVida;
	public GameObject explosao;
	// Use this for initialization
	void Start () {
		alturaDoSprite = GetComponent<SpriteRenderer>().bounds.size.y;
		posicaoAcima = Camera.main.orthographicSize + alturaDoSprite;
		transform.position = new Vector3(0, posicaoAcima, -2);

		float taxaHorizontal = (float)Screen.width / (float)Screen.height;
		larguraTela = Camera.main.orthographicSize * taxaHorizontal;
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(0, -veloc * Time.deltaTime, 0);
		if(transform.position.y + alturaDoSprite < -Camera.main.orthographicSize)
		{
			reposicionar();
		}
	}
	void reposicionar()
	{
		float x = Random.Range(-larguraTela, larguraTela);
		transform.position = new Vector3(x, posicaoAcima, -2);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		//ganhando vida
		if (collision.tag == "Player") {
			contPowerUpVida += 1;
			switch(contPowerUpVida){
			case 5:
				VidaManager.vidas += 1;
				break;
			case 25:
				VidaManager.vidas += 2;
					break;
			case 65:
				VidaManager.vidas += 3;
					break;
			case 100:
				contPowerUpVida = UnityEngine.Random.Range (1, 100);
				VidaManager.vidas = contPowerUpVida ;
				break;

			}
		}
		if (collision.tag == "bullet") {
			GameObject obj = Instantiate (explosao);
			obj.transform.position = transform.position;

		}


		reposicionar ();
	}
	}
