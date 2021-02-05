using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroScript : MonoBehaviour {

    public float veloc;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, veloc * Time.deltaTime, 0);
        }
    
 
}
