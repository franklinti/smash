using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavePowerUp : MonoBehaviour {
	float veloc = 10f;
	//public GameObject tempPrefab;
	//private float posX  = 1f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		float deslocx = x * veloc * Time.deltaTime;
		float y = Input.GetAxis("Vertical");
		float deslocy = y * veloc * Time.deltaTime;
		transform.Translate(deslocx, deslocy,0);
	}


}
