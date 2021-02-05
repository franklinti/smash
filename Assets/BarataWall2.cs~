using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarataWall2 : BarataModel
{
	void Awake(){
		speedWall2 = 0.5f;
	}
	public void  moveBWall2(){
		moveBarata.Translate (0,-speedWall2 * Time.deltaTime,0);
	}
	public void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.CompareTag ("Player")) {
			colisao = true;
		}
	}
	void AumentaVelocidade(){
		switch (qtdReposicao) {
		case 5:speedWall2 = 0.7f;break;
		case 6:speedWall2 = 0.8f;break;
		}
	}
	void Reposicionar(){
		float x = Random.Range (-2, 3);
		transform.position = new Vector2 (x, 3);
	}
	public void Esmagar(){
		GameObject obj = Instantiate (barataSmash);
		obj.transform.position = this.transform.position;
		ASEsmaga.Play ();
		Instantiate (objponto);
		objponto.transform.position = this.transform.position;
		PontoManager.instance.pontos += 10;
		PontoManager.instance.qtdBaratas += 1;
		GameObject.Find ("Slider").GetComponent<Slider> ().value += 0.1f;
		Destroy (obj, 1.0f);
		Reposicionar ();
	}
	void Update(){
		moveBWall2 ();
		if (colisao) {
			qtdReposicao += 1;
			colisao = false;
			Reposicionar ();
		}
		//AumentaVelocidade ();
	}
}
