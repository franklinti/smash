using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroNavePowerUp : MonoBehaviour {

	//tiro nave lado direito
	public GameObject projetilPrefab;
	private float larguradoSprite;
	private Vector3 offset;
	// Use this for initialization
	void Start () {
		//ajuste posição da bullet no reforço nave
		larguradoSprite = GetComponent<SpriteRenderer>().bounds.size.x;
		offset = new Vector3(larguradoSprite/3,0, 0);
	}

	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Tiro"))
		{
			Vector3 vetorPosicao = transform.rotation * offset;
			Object projetil = Instantiate(projetilPrefab, transform.position + vetorPosicao, transform.rotation);

		}

	}
}
