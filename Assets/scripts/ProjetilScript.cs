using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

    public float veloc = -6;
	//float alturaDoSprite= 5f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, veloc * Time.deltaTime, 0);
		//garantir que a bullet seja destruida ao sair do cmapo de visão
		if(transform.position.y > 6)
		{
			Destroy(gameObject);
		}
	}
}
