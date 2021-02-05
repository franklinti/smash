using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AsteroideColide : MonoBehaviour {

  //  float veloc = 3f;
    const float LIMITE_VERTICAL = 2f;
    const float LIMITE_HORIZONTAL = 5F;
	// Use this for initialization
	void Start () {
        Reposicionar();
	}
    // Update is called once per frame
    void Update()
    {
       // transform.Translate(0, -veloc * Time.deltaTime, 0);
       // if(transform.position.y <= -LIMITE_VERTICAL)
       // {
      //      Reposicionar();
      //  }
    }
    private void Reposicionar()
    {
        float x = UnityEngine.Random.Range(-LIMITE_HORIZONTAL, LIMITE_VERTICAL);
        transform.position = new Vector3(x, LIMITE_VERTICAL, -2);
    }

    
}
