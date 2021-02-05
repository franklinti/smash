using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroInimigo1 : MonoBehaviour {
	private float larguraDoSprite;
	public Vector3 offset;
	public GameObject projetilInimigoPrefab;
	// Use this for initialization
	void Start () {
		//posição da bala no rosto do inimigo
		larguraDoSprite= GetComponent<SpriteRenderer>().bounds.size.y;
		offset = new Vector3(larguraDoSprite/-8,-0.65f , 0);

	}

	// Update is called once per frame
	void Update () {
		/*
		if(MoveInimigo.contReposicionar){
			//Object projetil = Instantiate(projetilInimigoPrefab, transform.position, transform.rotation);
				Vector3 vetorPosicao = transform.rotation * offset;
				Object projetil = Instantiate(projetilInimigoPrefab, transform.position + vetorPosicao, transform.rotation);

		}
		*/	

		if (Input.GetButtonDown("Tiro"))
		{
			Vector3 vetorPosicao = transform.rotation * offset;
			Object projetil = Instantiate(projetilInimigoPrefab, transform.position + vetorPosicao, transform.rotation);

		}

	}
}
