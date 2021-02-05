using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveScript : MonoBehaviour {

    float veloc = 10;
	public GameObject spaceshipPowerUpPreFab;
	private int contPowerUp;
	private float posY  = -3f;
	// Use this for initialization
	void Start () {
		VidaManager.vidas = 3;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float deslocx = x * veloc * Time.deltaTime;

		float y = Input.GetAxis("Vertical");
        float deslocy = y * veloc * Time.deltaTime;
		transform.Translate(deslocx, deslocy,0);
        
	}
    
      private void OnTriggerEnter2D(Collider2D collision)
      {
        //adicionando powerUp de reforço spaceship
		if(collision.tag == "powerUp"){
			//contagem powerUp para receber uam nave de apoio
			contPowerUp += 1;
			switch(contPowerUp){
			case 2:
				//instancia a nave de apoio
				GameObject tempPrefab = Instantiate (spaceshipPowerUpPreFab)as GameObject;
				tempPrefab.transform.position = new Vector3 (transform.position.x,posY, transform.position.z);
				break;
			}
		}

      }
      
}
